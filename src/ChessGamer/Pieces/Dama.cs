namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    public class Dama : Piece {
        public Dama(ConsoleColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, ref Field[,] fields) {
            return true;
        }

        internal override bool ValidFilds(int line, int column, ref Field[,] fields) {
            return true;
        }

        public override string ToString() {
            return " D ";
        }
    }
}
