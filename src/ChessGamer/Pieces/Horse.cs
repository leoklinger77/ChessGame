namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Horse : Piece {
        public Horse(ConsoleColor color) : base(color) {
        }

        internal override bool FieldAttacked(int row, int column, ref Field[,] fields) {
            return true;
        }

        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            int validRow = row - 2;
            if (validRow < 0) {
                validRow = row + 2;
            }
            int higth = column - 1;
            int left = column + 1;

            for (int rrow = 0; rrow < 8; rrow++) {
                for (int ccolumn = 0; ccolumn < 8; ccolumn++) {

                    if (rrow == validRow && (left == ccolumn || higth == ccolumn)) {
                        var fiel = fields[rrow, ccolumn];
                        if (fiel != null) {
                            fiel.EnableValidPosition();
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
