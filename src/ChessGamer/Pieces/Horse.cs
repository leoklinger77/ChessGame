namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Horse : Piece {
        public Horse(ConsoleColor color) : base(color) {
        }        

        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            var current = fields[row, column];
            for (int rrow = 0; rrow < 8; rrow++) {
                for (int ccolumn = 0; ccolumn < 8; ccolumn++) {

                    if (rrow == row - 2 || rrow == row + 2) {
                        if (ccolumn == column + 1 || ccolumn == column - 1) {
                            var fiel = fields[rrow, ccolumn];

                            if (fiel.Piece == null || (fiel.Piece != null && fiel.Piece.Color != current.Piece.Color)) {
                                fiel.EnableValidPosition();
                            }
                        }
                    }

                    if (rrow == row - 1 || rrow == row + 1) {
                        if (ccolumn == column + 2 || ccolumn == column - 2) {
                            var fiel = fields[rrow, ccolumn];
                            if (fiel.Piece == null || (fiel.Piece != null && fiel.Piece.Color != current.Piece.Color)) {
                                fiel.EnableValidPosition();

                            }
                        }
                    }
                }
            }
            return true;
        }

        public override string ToString() {
            return " C ";
        }
    }
}
