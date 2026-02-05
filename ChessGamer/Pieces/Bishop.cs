namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Bishop : Piece {
        public Bishop(PieceColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            // Check all four diagonal directions
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
            return " B ";
        }       
    }
}
