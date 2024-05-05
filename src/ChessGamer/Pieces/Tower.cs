namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Tower : Piece {
        public Tower(ConsoleColor color) : base(color) {
        }
                
        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            return true;
        }

        public override string ToString() {
            return " T ";
        }
    }
}
