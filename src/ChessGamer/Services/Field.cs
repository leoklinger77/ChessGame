namespace ChessGamer.Services {
    using ChessGamer.Pieces;

    public class Field {
        public PiecePosition Position { get; set; }
        public Piece Piece { get; private set; }
        public bool ValidPosition { get; private set; }

        public int Row => Position.Row;
        public int Column => Position.Column;

        public Field(PiecePosition position, Piece piece = null) {
            Position = position;
            Piece = piece;
        }

        public void EnableValidPosition() {
            ValidPosition = true;
        }

        public void DisableValidPosition() {
            ValidPosition = false;
        }

        internal void SetPiece(Piece piece) {
            if (piece == null) {
                throw new ArgumentNullException(nameof(piece));
            }
            Piece = piece;
        }

        internal void NullPiece() {
            Piece = null;
        }

        internal bool IsValidPosition(int row, int column) {
            if (row < 0 || row > 7 || column < 0 || column > 7) {
                return false;
            }
            return true;
        }

        public override string ToString() {
            var srt = string.Empty;
            if (Piece == null) {
                srt = " _ ";
            } else {
                srt = Piece.ToString();
            }
            //srt += $" Attacked: {FieldAttacked} |  Validation: {ValidPosition} | PieceColor: {Piece?.Color}";

            return srt;
        }
    }
}
