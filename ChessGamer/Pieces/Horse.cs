namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Horse : Piece {
        public Horse(PieceColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            
            // Knight moves in L-shape: 2 squares in one direction, 1 in perpendicular
            int[] lineOffsets = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] columnOffsets = { -1, 1, -2, 2, -2, 2, -1, 1 };
            
            for (int i = 0; i < 8; i++) {
                int newLine = line + lineOffsets[i];
                int newColumn = column + columnOffsets[i];
                
                if (newLine >= 0 && newLine < 8 && newColumn >= 0 && newColumn < 8) {
                    var field = fields[newLine, newColumn];
                    if (field.Piece != null && field.Piece.Color != Color) {
                        field.EnableFieldAttacked();
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
            
            // Knight moves in L-shape
            int[] lineOffsets = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] columnOffsets = { -1, 1, -2, 2, -2, 2, -1, 1 };
            
            for (int i = 0; i < 8; i++) {
                int newLine = line + lineOffsets[i];
                int newColumn = column + columnOffsets[i];
                
                if (newLine >= 0 && newLine < 8 && newColumn >= 0 && newColumn < 8) {
                    var field = fields[newLine, newColumn];
                    if (field.Piece == null || field.Piece.Color != Color) {
                        field.EnableValidPosition();
                        valid = true;
                    }
                }
            }
            
            return valid;
        }

        public override string ToString() {
            return " C ";
        }
    }
}
