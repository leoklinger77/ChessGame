namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Tower : Piece {
        public Tower(ConsoleColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, ref Field[,] fields) {
            return true;
        }

        internal override bool ValidFilds(int line, int column, ref Field[,] fields) {
            return true;
        }

        public override string ToString() {
            return " T ";
        }
    }
}
