namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Tower : Piece {
        public Tower(PieceColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            // Check vertical and horizontal lines for attacks
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
            
            return true;
        }

        internal override bool ValidFields(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            bool valid = false;
            
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
            
            return valid;
        }

        public override string ToString() {
            return " T ";
        }
    }
}
