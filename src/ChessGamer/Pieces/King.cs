namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class King : Piece {
        public King(ConsoleColor color) : base(color) {
        }

        internal override bool FieldAttacked(int row, int column, ref Field[,] fields) {
            return true;
        }

        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            return true;
        }

        public override string ToString() {
            return " R ";
        }
    }
}
