namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Tower : Piece {
        public Tower(ConsoleColor color) : base(color) {
        }

        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            var current = fields[row, column];

            for (int i = row - 1; i >= 0; i--) {
                if (VerifildPosition(i, column, current, ref fields)) {
                    break;
                }
            }

            for (int i = row + 1; i < 8; i++) {
                if (VerifildPosition(i, column, current, ref fields)) {
                    break;
                }
            }

            for (int i = column - 1; i >= 0; i--) {
                if (VerifildPosition(row, i, current, ref fields)) {
                    break;
                }
            }

            for (int i = column + 1; i < 8; i++) {
                if (VerifildPosition(row, i, current, ref fields)) {
                    break;
                }
            }
            return true;
        }

        private bool VerifildPosition(int row, int collum, Field current, ref Field[,] fields) {
            var fieldd = fields[row, collum];
            if (fieldd.Piece != null) {
                if (fieldd.Piece.Color != current.Piece.Color) {
                    fieldd.EnableValidPosition();
                    return true;
                } else {
                    return true;
                }
            } else {
                fieldd.EnableValidPosition();
            }
            return false;
        }

        public override string ToString() {
            return " T ";
        }
    }
}
