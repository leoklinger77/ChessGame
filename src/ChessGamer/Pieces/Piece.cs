namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public abstract class Piece {
        protected Field _current;
        public int QtyMove = 0;
        public ConsoleColor? Color { get; protected set; }

        public Piece() {
        }

        public Piece(ConsoleColor color) {
            Color = color;
        }

        protected void IncrementMove() {
            QtyMove += 1;
        }        

        protected bool CanMove(Field field) {
            if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                return false;
            }
            return true;
        }

        protected bool IsValid() {
            return _current == null || _current.Piece.Color != Color;
        }

        internal abstract bool ValidFilds(PiecePosition position, ref Field[,] fields);
    }
}
