namespace ChessGamer.Services {
    using ChessGamer.Pieces;
    using System;
    using System.Drawing;

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
        private IDictionary<char, int> _line = new Dictionary<char, int>() {
            { '1', 7 },
            { '2', 6 },
            { '3', 5 },
            { '4', 4 },
            { '5', 3 },
            { '6', 2 },
            { '7', 1 },
            { '8', 0 },
        };
        private IDictionary<PieceColor, List<Piece>> _captureFields = new Dictionary<PieceColor, List<Piece>>();
        private Field[,] _fields = new Field[8, 8];
        private MoveHistory _moveHistory = new MoveHistory();
        private (int line, int column)? _enPassantTarget = null;
        private Dictionary<Piece, bool> _pieceHasMoved = new Dictionary<Piece, bool>();

        public PieceColor ColorBlack { get; private set; } = PieceColor.Black;
        public PieceColor ColorWhite { get; private set; } = PieceColor.White;
        public bool IsWhite { get; private set; } = true;
        public int Count { get; private set; } = 0;
        public bool IsInCheck { get; private set; } = false;
        public bool IsCheckmate { get; private set; } = false;

        public Board() {
            CreatedBoard();
        }
        public Field[,] Fields() => _fields;
        public IDictionary<PieceColor, List<Piece>> CaptureFields() => _captureFields;
        public MoveHistory GetMoveHistory() => _moveHistory;
        public bool CanUndo() => _moveHistory.CanUndo();
        public bool CanRedo() => _moveHistory.CanRedo();
        public (int line, int column)? GetEnPassantTarget() => _enPassantTarget;
        public bool HasPieceMoved(Piece piece) => _pieceHasMoved.ContainsKey(piece) && _pieceHasMoved[piece];

        public bool TryGetField(Point point, out Field field, out string ransom) {
            ransom = string.Empty;
            var y = 7 - point.Y;

            field = _fields[point.Y, point.X];
            if (field == null || field.Piece == null) {
                ransom = $"There is no piece in the selected field";
                return false;
            }

            if (!WhoPlays(field, ref ransom)) {
                return false;
            }

            field.Piece.ValidFields(point.Y, point.X, _fields);

            field.Piece.FieldAttacked(field.Line, field.Column, _fields);

            return true;
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
            if (field == null || field.Piece == null) {
                ransom = $"There is no piece in the {position} selected field";
                return false;
            }

            if (!WhoPlays(field, ref ransom)) {
                return false;
            }

            field.Piece.ValidFields(line, column, _fields);

            field.Piece.FieldAttacked(field.Line, field.Column, _fields);

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
            if (old.Piece.ValidFields(old.Line, old.Column, _fields)) {
                old.Piece.FieldAttacked(old.Line, old.Column, _fields);
                if (!_fields[line, column].ValidPosition) {
                    ransom = "Invalid Move";
                    return false;
                }
            }

            if (!MoveToFrom(old, ref from, ref ransom)) {
                return false;
            }

            // Toggle turn
            IsWhite = !IsWhite;
            Count++;

            // Check if CURRENT player (who just moved) king is in check or checkmate
            // After toggle, check the player who will play next
            var currentPlayerColor = IsWhite ? ColorWhite : ColorBlack;
            IsInCheck = IsKingInCheck(currentPlayerColor);
            IsCheckmate = IsInCheck && CheckForCheckmate(currentPlayerColor);

            return true;
        }

        private bool MoveToFrom(Field oldField, ref Field fromPosition, ref string ransom) {
            if (oldField == null) {
                throw new Exception("Old field is required");
            }
            if (fromPosition == null) {
                throw new Exception("Old field is required");
            }

            if (!oldField.Piece.ValidFields(oldField.Line, oldField.Column, _fields)) {
                ransom = "Invalid Move";
                return false;
            }

            // Check if the move would put own king in check
            var movingPieceColor = oldField.Piece.Color;
            var capturedPiece = fromPosition.Piece;
            
            // Simulate the move
            var tempPiece = oldField.Piece;
            fromPosition.SetPiece(tempPiece);
            oldField.NullPiece();

            // Check if king is in check after this move
            bool wouldBeInCheck = IsKingInCheck(movingPieceColor);

            // Restore the board
            oldField.SetPiece(tempPiece);
            if (capturedPiece != null) {
                fromPosition.SetPiece(capturedPiece);
            } else {
                fromPosition.NullPiece();
            }

            if (wouldBeInCheck) {
                ransom = "Invalid Move - King would be in check";
                ClearMarkedFields();
                return false;
            }

            // Perform the actual move
            ClearMarkedFields();

            // Add to history before capturing
            var move = new Move(
                oldField.Line,
                oldField.Column,
                fromPosition.Line,
                fromPosition.Column,
                oldField.Piece,
                fromPosition.Piece,
                Count + 1
            );

            CapturedPiece(fromPosition);

            var movingPiece = oldField.Piece;
            fromPosition.SetPiece(movingPiece);
            oldField.NullPiece();

            // Mark piece as moved (for castling and pawn double-move)
            if (!_pieceHasMoved.ContainsKey(movingPiece)) {
                _pieceHasMoved[movingPiece] = true;
            }

            // Check for pawn promotion
            if (movingPiece is Pawn) {
                if ((movingPiece.Color == ColorWhite && fromPosition.Line == 0) ||
                    (movingPiece.Color == ColorBlack && fromPosition.Line == 7)) {
                    // Promote to Queen by default (could add choice later)
                    fromPosition.SetPiece(new Queen(movingPiece.Color));
                }

                // Track en passant target
                if (Math.Abs(oldField.Line - fromPosition.Line) == 2) {
                    int enPassantLine = (oldField.Line + fromPosition.Line) / 2;
                    _enPassantTarget = (enPassantLine, fromPosition.Column);
                } else {
                    _enPassantTarget = null;
                }
            } else {
                _enPassantTarget = null;
            }

            fromPosition.Piece.FieldAttacked(fromPosition.Line, fromPosition.Column, _fields);
            
            // Add move to history
            _moveHistory.AddMove(move);
            
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
            if (!_line.TryGetValue(old[1], out line)) {
                ransom = "Invalid line selected";
                return false;
            }
            return true;
        }

        private bool WhoPlays(Field field, ref string ransom) {
            try {
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
                        _fields[i, j] = new Field(i, j, new Pawn(ColorBlack));
                    } else if (i == 6) {
                        _fields[i, j] = new Field(i, j, new Pawn(ColorWhite));
                    } else {
                        _fields[i, j] = new Field(i, j);
                    }
                }
            }
            _fields[0, 0] = new Field(0, 0, new Tower(ColorBlack));
            _fields[0, 1] = new Field(0, 1, new Horse(ColorBlack));
            _fields[0, 2] = new Field(0, 2, new Bishop(ColorBlack));
            _fields[0, 3] = new Field(0, 3, new Queen(ColorBlack));
            _fields[0, 4] = new Field(0, 4, new King(ColorBlack));
            _fields[0, 5] = new Field(0, 5, new Bishop(ColorBlack));
            _fields[0, 6] = new Field(0, 6, new Horse(ColorBlack));
            _fields[0, 7] = new Field(0, 7, new Tower(ColorBlack));

            _fields[7, 0] = new Field(7, 0, new Tower(ColorWhite));
            _fields[7, 1] = new Field(7, 1, new Horse(ColorWhite));
            _fields[7, 2] = new Field(7, 2, new Bishop(ColorWhite));
            _fields[7, 3] = new Field(7, 3, new Queen(ColorWhite));
            _fields[7, 4] = new Field(7, 4, new King(ColorWhite));
            _fields[7, 5] = new Field(7, 5, new Bishop(ColorWhite));
            _fields[7, 6] = new Field(7, 6, new Horse(ColorWhite));
            _fields[7, 7] = new Field(7, 7, new Tower(ColorWhite));
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

        private (int, int)? FindKing(PieceColor color) {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var piece = _fields[i, j].Piece;
                    if (piece is King && piece.Color == color) {
                        return (i, j);
                    }
                }
            }
            return null;
        }

        public bool IsKingInCheck(PieceColor kingColor) {
            var kingPos = FindKing(kingColor);
            if (!kingPos.HasValue) {
                return false;
            }

            var (kingLine, kingColumn) = kingPos.Value;

            // Check if any opponent piece can attack the king
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var piece = _fields[i, j].Piece;
                    if (piece != null && piece.Color != kingColor) {
                        // Clear attack markers
                        ClearMarkedFields();
                        
                        // Mark fields this piece can attack
                        piece.FieldAttacked(i, j, _fields);
                        
                        // Check if king's position is marked as attacked
                        if (_fields[kingLine, kingColumn].FieldAttacked) {
                            ClearMarkedFields();
                            return true;
                        }
                    }
                }
            }
            
            ClearMarkedFields();
            return false;
        }

        private bool CheckForCheckmate(PieceColor kingColor) {
            // First, must be in check
            if (!IsKingInCheck(kingColor)) {
                return false;
            }

            // Try all possible moves for all pieces of the same color
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    var piece = _fields[i, j].Piece;
                    if (piece != null && piece.Color == kingColor) {
                        // Get valid moves for this piece
                        piece.ValidFields(i, j, _fields);

                        // Try each valid move
                        for (int ti = 0; ti < 8; ti++) {
                            for (int tj = 0; tj < 8; tj++) {
                                if (_fields[ti, tj].ValidPosition) {
                                    // Simulate the move
                                    var capturedPiece = _fields[ti, tj].Piece;
                                    _fields[ti, tj].SetPiece(piece);
                                    _fields[i, j].NullPiece();

                                    // Check if still in check
                                    bool stillInCheck = IsKingInCheck(kingColor);

                                    // Undo the move
                                    _fields[i, j].SetPiece(piece);
                                    if (capturedPiece != null) {
                                        _fields[ti, tj].SetPiece(capturedPiece);
                                    } else {
                                        _fields[ti, tj].NullPiece();
                                    }

                                    ClearMarkedFields();

                                    // If this move gets out of check, it's not checkmate
                                    if (!stillInCheck) {
                                        return false;
                                    }
                                }
                            }
                        }
                        
                        ClearMarkedFields();
                    }
                }
            }

            // No valid move found that gets out of check - it's checkmate
            return true;
        }

        public bool UndoMove() {
            var move = _moveHistory.UndoMove();
            if (move == null) {
                return false;
            }

            // Restore the piece to original position
            _fields[move.FromLine, move.FromColumn].SetPiece(move.MovedPiece);
            
            // Restore captured piece or clear destination
            if (move.CapturedPiece != null) {
                _fields[move.ToLine, move.ToColumn].SetPiece(move.CapturedPiece);
                // Remove from captured list
                if (_captureFields.TryGetValue(move.CapturedPiece.Color, out var captureList)) {
                    captureList.Remove(move.CapturedPiece);
                }
            } else {
                _fields[move.ToLine, move.ToColumn].NullPiece();
            }

            // Toggle turn
            IsWhite = !IsWhite;
            Count--;

            // Update check status
            IsInCheck = IsKingInCheck(IsWhite ? ColorWhite : ColorBlack);
            IsCheckmate = IsInCheck && CheckForCheckmate(IsWhite ? ColorWhite : ColorBlack);

            return true;
        }

        public bool RedoMove() {
            var move = _moveHistory.RedoMove();
            if (move == null) {
                return false;
            }

            // Redo the move
            _fields[move.ToLine, move.ToColumn].SetPiece(move.MovedPiece);
            _fields[move.FromLine, move.FromColumn].NullPiece();

            if (move.CapturedPiece != null) {
                CapturedPiece(_fields[move.ToLine, move.ToColumn]);
            }

            // Toggle turn
            IsWhite = !IsWhite;
            Count++;

            // Update check status
            IsInCheck = IsKingInCheck(IsWhite ? ColorWhite : ColorBlack);
            IsCheckmate = IsInCheck && CheckForCheckmate(IsWhite ? ColorWhite : ColorBlack);

            return true;
        }
    }
}
