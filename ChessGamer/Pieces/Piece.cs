namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    public abstract class Piece {
        public ConsoleColor Color { get; protected set; }
        
        public Piece(ConsoleColor color) {
            Color = color;
        }

        internal abstract bool FieldAttacked(int line, int column, ref Field[,] fields);

        internal abstract bool ValidFilds(int line, int column, ref Field[,] fields);
    }
}
