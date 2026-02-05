namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    public abstract class Piece {
        public PieceColor Color { get; protected set; }
        
        public Piece(PieceColor color) {
            Color = color;
        }

        internal abstract bool FieldAttacked(int line, int column, Field[,] fields);

        internal abstract bool ValidFields(int line, int column, Field[,] fields);
    }
}
