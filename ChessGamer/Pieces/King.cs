namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class King : Piece {
        public King(PieceColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            // King can attack all adjacent squares
            for (int i = -1; i <= 1; i++) {
                for (int j = -1; j <= 1; j++) {
                    if (i == 0 && j == 0) continue;
                    
                    int newLine = line + i;
                    int newColumn = column + j;
                    
                    if (newLine >= 0 && newLine < 8 && newColumn >= 0 && newColumn < 8) {
                        var field = fields[newLine, newColumn];
                        if (field.Piece != null && field.Piece.Color != Color) {
                            field.EnableFieldAttacked();
                        }
                    }
                }
            }
            return true;
        }

        internal override bool ValidFields(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            bool valid = false;
            // King can move to all adjacent squares
            for (int i = -1; i <= 1; i++) {
                for (int j = -1; j <= 1; j++) {
                    if (i == 0 && j == 0) continue;
                    
                    int newLine = line + i;
                    int newColumn = column + j;
                    
                    if (newLine >= 0 && newLine < 8 && newColumn >= 0 && newColumn < 8) {
                        var field = fields[newLine, newColumn];
                        if (field.Piece == null || field.Piece.Color != Color) {
                            field.EnableValidPosition();
                            valid = true;
                        }
                    }
                }
            }
            return valid;
        }

        public override string ToString() {
            return " R ";
        }
    }
}
