namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Bishop : Piece {
        public Bishop(ConsoleColor color) : base(color) {
        }
        
        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            for (int rrow = 0; rrow < 8; rrow++) {
                for (int ccolumn = 0; ccolumn < 8; ccolumn++) {

                }
            }
            return true;
        }

        public override string ToString() {
            return " B ";
        }       
    }
}
