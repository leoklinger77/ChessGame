namespace ChessGamer.Services {
    public class PiecePosition {
        public int Column { get; private set; }
        public int Row { get; private set; }
        public PiecePosition(int row, int column) {
            SetPosition(row, column);
        }
        public override string ToString() {
            return $"Row: {Row} | Column: {Column}";
        }

        public void SetPosition(int row, int column) {
            Column = column;
            Row = row;
        }

        public static PiecePosition Position(int row, int column) {
            return new PiecePosition(row, column);
        }

        public string GetKey() {
            return this.ToString();
        }
    }
}
