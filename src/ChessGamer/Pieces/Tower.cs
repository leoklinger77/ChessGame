namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Tower : Piece {
        public Tower(ConsoleColor color) : base(color) {
        }

        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {
            _current = fields[position.Row, position.Column];
            //Up
            var value = position.Row - 1;
            while (_current.IsValidPosition(value, position.Column) != IsValid()) {
                var field = fields[value, position.Column];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                value--;

            }

            // Bottom
            value = position.Row + 1;
            while (_current.IsValidPosition(value, position.Column) != IsValid()) {
                var field = fields[value, position.Column];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                value++;

            }

            //// R
            value = position.Column + 1;
            while (_current.IsValidPosition(position.Row, value) != IsValid()) {
                var field = fields[position.Row, value];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                value++;

            }

            //// L
            value = position.Column - 1;
            while (_current.IsValidPosition(position.Row, value) != IsValid()) {
                var field = fields[position.Row, value];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                value--;

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
