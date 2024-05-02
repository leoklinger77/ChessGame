namespace ChessGamer.Services {
    public class PiecePosition {
        public int Column { get; private set; }
        public int Row { get; private set; }
        public PiecePosition(int column, int row) {
            Column = column;
            Row = row;
        }
        public override string ToString() {
            return $"Column: {Column} | Row: {Row}";
        }

        public static PiecePosition Position(int column, int row) {
            return new PiecePosition(column, row);
        }
    }
}
