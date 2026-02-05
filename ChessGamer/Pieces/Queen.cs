namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    public class Queen : Piece {
        public Queen(PieceColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            // Queen = Rook + Bishop, check all 8 directions
            
            // Vertical and Horizontal (like Tower)
            // Up
            for (int i = line - 1; i >= 0; i--) {
                var field = fields[i, column];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Down
            for (int i = line + 1; i < 8; i++) {
                var field = fields[i, column];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Left
            for (int j = column - 1; j >= 0; j--) {
                var field = fields[line, j];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Right
            for (int j = column + 1; j < 8; j++) {
                var field = fields[line, j];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Diagonals (like Bishop)
            // Up-Right
            for (int i = 1; line - i >= 0 && column + i < 8; i++) {
                var field = fields[line - i, column + i];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Up-Left
            for (int i = 1; line - i >= 0 && column - i >= 0; i++) {
                var field = fields[line - i, column - i];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Down-Right
            for (int i = 1; line + i < 8 && column + i < 8; i++) {
                var field = fields[line + i, column + i];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            // Down-Left
            for (int i = 1; line + i < 8 && column - i >= 0; i++) {
                var field = fields[line + i, column - i];
                if (field.Piece != null) {
                    if (field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
                    }
                    break;
                }
            }
            
            return true;
        }

        internal override bool ValidFields(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            bool valid = false;
            
            // Vertical and Horizontal
            // Up
            for (int i = line - 1; i >= 0; i--) {
                var field = fields[i, column];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Down
            for (int i = line + 1; i < 8; i++) {
                var field = fields[i, column];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Left
            for (int j = column - 1; j >= 0; j--) {
                var field = fields[line, j];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Right
            for (int j = column + 1; j < 8; j++) {
                var field = fields[line, j];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Diagonals
            // Up-Right
            for (int i = 1; line - i >= 0 && column + i < 8; i++) {
                var field = fields[line - i, column + i];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Up-Left
            for (int i = 1; line - i >= 0 && column - i >= 0; i++) {
                var field = fields[line - i, column - i];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Down-Right
            for (int i = 1; line + i < 8 && column + i < 8; i++) {
                var field = fields[line + i, column + i];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            // Down-Left
            for (int i = 1; line + i < 8 && column - i >= 0; i++) {
                var field = fields[line + i, column - i];
                if (field.Piece == null) {
                    field.EnableValidPosition();
                    valid = true;
                } else {
                    if (field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                    break;
                }
            }
            
            return valid;
        }

        public override string ToString() {
            return " D ";
        }
    }
}
