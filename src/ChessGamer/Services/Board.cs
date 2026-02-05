namespace ChessGamer.Services {
    using ChessGamer.Pieces;
    using ChessGamer.Tools;
    using System;
    using System.Reactive.Linq;
    using System.Reactive.Subjects;

    public class Board {
        private IDictionary<ConsoleColor, List<Piece>> _captureFields = new Dictionary<ConsoleColor, List<Piece>>();
        private Field[,] _fields = new Field[8, 8];

        public ISubject<SelectPosition> SubjectRock = new Subject<SelectPosition>();
        public ISubject<ConsoleColor> SubjectPlay = new Subject<ConsoleColor>();
        public ConsoleColor ColorBlack { get; private set; } = ConsoleColor.Yellow;
        public ConsoleColor ColorWhite { get; private set; } = ConsoleColor.White;
        public bool IsWhite { get; private set; } = true;
        public int Count { get; private set; } = 0;

        public Board() {
            CreatedBoard();
        }

        public Field[,] Fields() => _fields;

        public IDictionary<ConsoleColor, List<Piece>> CaptureFields() => _captureFields;

        public bool TryGetField(PiecePosition select, out Field field, out string ransom) {
            ransom = string.Empty;

            field = _fields[select.Row, select.Column];
            if (field == null && field.Piece == null) {
                ransom = $"There is no piece in the selected field";
                return false;
            }

            if (!WhoPlays(field, ref ransom)) {
                return false;
            }

            ClearFiltAttacked(ref _fields);

            field.Piece.ValidFilds(select, ref _fields);

            return true;
        }

        private void ClearFiltAttacked(ref Field[,] board) {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var field = board[i, j];
                    if (field.ValidPosition) {
                        field.DisableValidPosition();
                    }
                }
            }
        }

        public bool TryGetField(string position, out Field field, out string ransom) {
            field = null;
            ransom = string.Empty;
            if (position.Length != 2) {
                ransom = "Invalid field selection, type for example E4 E6";
                return false;
            }

            if (!TryGetColumnRowByPosition(position, out var column, out var line, ref ransom)) {
                return false;
            }

            field = _fields[column, line];
            if (field == null && field.Piece == null) {
                ransom = $"There is no piece in the {position} selected field";
                return false;
            }

            if (!WhoPlays(field, ref ransom)) {
                return false;
            }

            field.Piece.ValidFilds(field.Position, ref _fields);

            return true;
        }

        public bool TryMove(Field fromFiel, PiecePosition toPosition, out string ransom) {
            ransom = string.Empty;
            if (fromFiel == null) {
                throw new Exception("Old field is required");
            }

            if (toPosition == null) {
                ransom = "Invalid field selection, type for example E4 E6";
                return false;
            }

            if (!WhoPlays(fromFiel, ref ransom)) {
                return false;
            }

            var from = _fields[toPosition.Row, toPosition.Column];
            if (from.ValidPosition) {
                if (!_fields[toPosition.Row, toPosition.Column].ValidPosition) {
                    ransom = "Invalid Move";
                    return false;
                }
            }

            if (!MoveToFrom(fromFiel, ref from, ref ransom)) {
                return false;
            }

            if (IsWhite) {
                IsWhite = false;
                SubjectPlay.OnNext(ColorBlack);
            } else {
                IsWhite = true;
                SubjectPlay.OnNext(ColorWhite);
            }
            Count++;
            return true;
        }

        public bool TryMove(Field old, string fromField, out string ransom) {
            ransom = string.Empty;
            if (old == null) {
                throw new Exception("Old field is required");
            }

            if (fromField.Length != 2) {
                ransom = "Invalid field selection, type for example E4 E6";
                return false;
            }

            if (!WhoPlays(old, ref ransom)) {
                return false;
            }

            if (!TryGetColumnRowByPosition(fromField, out var column, out var line, ref ransom)) {
                return false;
            }

            var from = _fields[column, line];
            if (old.Piece.ValidFilds(old.Position, ref _fields)) {
                if (!_fields[column, line].ValidPosition) {
                    ransom = "Invalid Move";
                    return false;
                }
            }

            if (!MoveToFrom(old, ref from, ref ransom)) {
                return false;
            }

            if (IsWhite) {
                IsWhite = false;
            } else {
                IsWhite = true;
            }
            Count++;
            return true;
        }

        public IDictionary<string, SelectPosition> GetValidFilds(Field origin) {
            var result = new Dictionary<string, SelectPosition>();
            for (int row = 0; row < 8; row++) {
                for (int collumn = 0; collumn < 8; collumn++) {
                    var fieldMark = _fields[row, collumn];
                    if (fieldMark.ValidPosition) {
                        var select = new SelectPosition(origin, fieldMark);
                        result.Add(select.GetDestinationKey(), select);
                    }
                }
            }
            return result;
        }

        public void ClearMarkedFields(Field field) {
            if (field.ValidPosition) {
                Console.BackgroundColor = ConsoleColor.Black;
                field.DisableValidPosition();
            }
        }

        private bool MoveToFrom(Field oldField, ref Field fromPosition, ref string ransom) {
            if (oldField == null) {
                throw new Exception("Old field is required");
            }
            if (fromPosition == null) {
                throw new Exception("Old field is required");
            }

            if (!oldField.Piece.ValidFilds(oldField.Position, ref _fields)) {
                ransom = "Invalid Move";
                return false;
            }

            ClearMarkedFields();

            CapturedPiece(fromPosition);

            if (oldField.Piece is King king && Math.Abs(oldField.Column - fromPosition.Column) > 1) {
                Rock(fromPosition);
            }

            fromPosition.SetPiece(oldField.Piece);
            oldField.NullPiece();



            return true;
        }

        private void Rock(Field fromPosition) {
            var columnTower = fromPosition.Column == 6 ? 7 : 0;
            Field tower = _fields[fromPosition.Row, columnTower];
            Field fromTower = null;
            if (fromPosition.Column == 2) {
                fromTower = _fields[fromPosition.Row, 3];
            } else {
                fromTower = _fields[fromPosition.Row, 5];
            }

            if (fromTower.Piece == null) {
                fromTower.SetPiece(tower.Piece);
                tower.NullPiece();
                SubjectRock.OnNext(new SelectPosition(tower, fromTower));
            }
        }

        private void CapturedPiece(Field field) {
            if (field.Piece != null) {
                if (_captureFields.TryGetValue(field.Piece.Color.Value, out List<Piece> capture)) {
                    capture.Add(field.Piece);
                } else {
                    _captureFields.Add(field.Piece.Color.Value, new List<Piece>() { field.Piece });
                }
            }
        }

        public bool TryGetColumnRowByPosition(string position, out int column, out int line, ref string ransom) {
            var old = position.ToArray();
            column = 0;
            line = 0;
            if (!Assistant._columnTextToNum.TryGetValue(old[0], out column)) {
                ransom = "Invalid column selected";
                return false;
            }
            if (!Assistant._rowTextToNum.TryGetValue(old[1], out line)) {
                ransom = "Invalid line selected";
                return false;
            }
            return true;
        }

        private bool WhoPlays(Field field, ref string ransom) {
            try {
                if (field.Piece == null) {
                    ransom = "Move invalid";
                    return false;
                }
                if (IsWhite == false && field.Piece.Color == ColorWhite) {
                    ransom = "Move invalid, Black's turn";
                    return false;
                } else if (IsWhite == true && field.Piece.Color == ColorBlack) {
                    ransom = "Move invalid, White's turn";
                    return false;
                }
            } catch (Exception) {
                ransom = "Selected field does not contain piece";
                return false;
            }

            return true;
        }

        private void CreatedBoard() {
            for (int row = 0; row < 8; row++) {
                for (int column = 0; column < 8; column++) {

                    if (row == 0 || row == 7) {
                        var collor = row == 0 ? ColorBlack : ColorWhite;
                        switch (column) {
                            case 0:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Tower(collor));
                                break;
                            case 1:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Horse(collor));
                                break;
                            case 2:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Bishop(collor));
                                break;
                            case 3:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Dama(collor));
                                break;
                            case 4:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new King(collor));
                                break;
                            case 5:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Bishop(collor));
                                break;
                            case 6:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Horse(collor));
                                break;
                            case 7:
                                _fields[row, column] = new Field(PiecePosition.Position(row, column), new Tower(collor));
                                break;
                        }
                    } else if (row == 1) {

                        _fields[row, column] = new Field(PiecePosition.Position(row, column), new Pawn(ColorBlack));

                    } else if (row == 6) {

                        _fields[row, column] = new Field(PiecePosition.Position(row, column), new Pawn(ColorWhite));

                    } else {
                        _fields[row, column] = new Field(PiecePosition.Position(row, column));
                    }
                }
            }
        }

        private void ClearMarkedFields() {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var field = _fields[i, j];
                    ClearMarkedFields(field);
                }
            }
        }
    }
}
