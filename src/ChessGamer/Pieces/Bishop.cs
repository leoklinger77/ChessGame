namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Bishop : Piece {
        public Bishop(ConsoleColor color) : base(color) {
        }
        
        internal override bool ValidFilds(int line, int column, ref Field[,] fields) {
            return true;
        }

        public override string ToString() {
            return " B ";
        }       
    }
}
