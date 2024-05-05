namespace ChessGamer.Services {
    using ChessGamer.Pieces;

    public class Field {
        public PiecePosition Position { get; set; }
        public Piece Piece { get; private set; }
        public bool ValidPosition { get; private set; }
        public bool FieldAttacked { get; private set; }

        public int Row => Position.Row;
        public int Column => Position.Column;

        public Field(PiecePosition position, Piece piece = null) {
            Position = position;
            Piece = piece;
        }
        public void EnableFieldAttacked() {
            FieldAttacked = true;
            EnableValidPosition();
        }
        public void EnableValidPosition() {
            ValidPosition = true;
        }

        public void DisableFieldAttacked() {
            FieldAttacked = false;
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

        internal bool IsValidPosition(Field[,] fields, int line, int column) {
            var field = fields[line, column];
            if (field.ValidPosition) {
                return true;
            }
            return false;
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
