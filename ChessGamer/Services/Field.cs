namespace ChessGamer.Services {
    using ChessGamer.Pieces;

    public class Field {
        public int Column { get; private set; }
        public int Line { get; private set; }
        public Piece Piece { get; private set; }
        public bool ValidPosition { get; private set; }
        public bool FieldAttacked { get; private set; }

        public Field(int line, int column, Piece piece = null) {
            Line = line;
            Column = column;
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
            if (Piece == null) {
                return " _ ";
            } else {
                return Piece.ToString();
            }
        }
    }
}
