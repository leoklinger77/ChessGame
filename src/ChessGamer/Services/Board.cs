namespace ChessGamer.Services {
    using ChessGamer.Pieces;
    using System;
    using System.Data.Common;
    using System.Security.Cryptography;

    public class Board {
        private IDictionary<char, int> _columnToNum = new Dictionary<char, int>() {
            { 'A', 0 },
            { 'B', 1 },
            { 'C', 2 },
            { 'D', 3 },
            { 'E', 4 },
            { 'F', 5 },
            { 'G', 6 },
            { 'H', 7 },
        };

        private IDictionary<char, int> _rowToNum = new Dictionary<char, int>() {
            { '1', 7 },
            { '2', 6 },
            { '3', 5 },
            { '4', 4 },
            { '5', 3 },
            { '6', 2 },
            { '7', 1 },
            { '8', 0 },
        };

        private IDictionary<ConsoleColor, List<Piece>> _captureFields = new Dictionary<ConsoleColor, List<Piece>>();

        private Field[,] _fields = new Field[8, 8];

        public ConsoleColor ColorBlack { get; private set; } = ConsoleColor.Yellow;
        public ConsoleColor ColorWhite { get; private set; } = ConsoleColor.White;
        public bool IsWhite { get; private set; } = true;
        public int Count { get; private set; } = 0;

        public Board() {
            CreatedBoard();
        }
        public Field[,] Fields() => _fields;
        public IDictionary<ConsoleColor, List<Piece>> CaptureFields() => _captureFields;

        public bool TryGetField(PiecePosition point, out Field field, out string ransom) {
            ransom = string.Empty;

            field = _fields[point.Row, point.Column];
            if (field == null && field.Piece == null) {
                ransom = $"There is no piece in the selected field";
                return false;
            }

            if (!WhoPlays(field, ref ransom)) {
                return false;
            }

            ClearFiltAttacked(ref _fields);

            field.Piece.ValidFilds(point.Row, point.Column, ref _fields);

            field.Piece.FieldAttacked(field.Row, field.Column, ref _fields);

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

            field = _fields[line, column];
            if (field == null && field.Piece == null) {
                ransom = $"There is no piece in the {position} selected field";
                return false;
            }

            if (!WhoPlays(field, ref ransom)) {
                return false;
            }

            field.Piece.ValidFilds(line, column, ref _fields);

            field.Piece.FieldAttacked(field.Row, field.Column, ref _fields);

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
            if (fromFiel.Piece.ValidFilds(fromFiel.Row, fromFiel.Column, ref _fields)) {
                fromFiel.Piece.FieldAttacked(fromFiel.Row, fromFiel.Column, ref _fields);
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
            } else {
                IsWhite = true;
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

            var from = _fields[line, column];
            if (old.Piece.ValidFilds(old.Row, old.Column, ref _fields)) {
                old.Piece.FieldAttacked(old.Row, old.Column, ref _fields);
                if (!_fields[line, column].ValidPosition) {
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

        private bool MoveToFrom(Field oldField, ref Field fromPosition, ref string ransom) {
            if (oldField == null) {
                throw new Exception("Old field is required");
            }
            if (fromPosition == null) {
                throw new Exception("Old field is required");
            }

            if (!oldField.Piece.ValidFilds(oldField.Row, oldField.Column, ref _fields)) {
                ransom = "Invalid Move";
                return false;
            }

            ClearMarkedFields();

            CapturedPiece(fromPosition);

            fromPosition.SetPiece(oldField.Piece);
            oldField.NullPiece();

            fromPosition.Piece.FieldAttacked(fromPosition.Row, fromPosition.Column, ref _fields);
            return true;
        }

        private void CapturedPiece(Field field) {
            if (field.Piece != null) {
                if (_captureFields.TryGetValue(field.Piece.Color, out List<Piece> capture)) {
                    capture.Add(field.Piece);
                } else {
                    _captureFields.Add(field.Piece.Color, new List<Piece>() { field.Piece });
                }
            }
        }

        private bool TryGetColumnRowByPosition(string position, out int column, out int line, ref string ransom) {
            var old = position.ToArray();
            column = 0;
            line = 0;
            if (!_columnToNum.TryGetValue(old[0], out column)) {
                ransom = "Invalid column selected";
                return false;
            }
            if (!_rowToNum.TryGetValue(old[1], out line)) {
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
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (i == 1) {
                        _fields[i, j] = new Field(PiecePosition.Position(j, i), new Pawn(ColorBlack));
                    } else if (i == 6) {
                        _fields[i, j] = new Field(PiecePosition.Position(j, i), new Pawn(ColorWhite));
                    } else {
                        _fields[i, j] = new Field(PiecePosition.Position(j, i));
                    }
                }
            }
            _fields[0, 0] = new Field(PiecePosition.Position(0, 0), new Tower(ColorBlack));
            _fields[0, 1] = new Field(PiecePosition.Position(0, 1), new Horse(ColorBlack));
            _fields[0, 2] = new Field(PiecePosition.Position(0, 2), new Bishop(ColorBlack));
            _fields[0, 3] = new Field(PiecePosition.Position(0, 3), new Dama(ColorBlack));
            _fields[0, 4] = new Field(PiecePosition.Position(0, 4), new King(ColorBlack));
            _fields[0, 5] = new Field(PiecePosition.Position(0, 5), new Bishop(ColorBlack));
            _fields[0, 6] = new Field(PiecePosition.Position(0, 6), new Horse(ColorBlack));
            _fields[0, 7] = new Field(PiecePosition.Position(0, 7), new Tower(ColorBlack));

            _fields[7, 0] = new Field(PiecePosition.Position(7, 0), new Tower(ColorWhite));
            _fields[7, 1] = new Field(PiecePosition.Position(7, 1), new Horse(ColorWhite));
            _fields[7, 2] = new Field(PiecePosition.Position(7, 2), new Bishop(ColorWhite));
            _fields[7, 3] = new Field(PiecePosition.Position(7, 3), new Dama(ColorWhite));
            _fields[7, 4] = new Field(PiecePosition.Position(7, 4), new King(ColorWhite));
            _fields[7, 5] = new Field(PiecePosition.Position(7, 5), new Bishop(ColorWhite));
            _fields[7, 6] = new Field(PiecePosition.Position(7, 6), new Horse(ColorWhite));
            _fields[7, 7] = new Field(PiecePosition.Position(7, 7), new Tower(ColorWhite));
        }
        private void ClearMarkedFields() {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var field = _fields[i, j];
                    ClearMarkedFields(field);
                }
            }
        }

        public void ClearMarkedFields(Field field) {
            if (field.FieldAttacked || field.ValidPosition) {
                Console.BackgroundColor = ConsoleColor.Black;
                field.DisableFieldAttacked();
                field.DisableValidPosition();
            }
        }
    }
}
