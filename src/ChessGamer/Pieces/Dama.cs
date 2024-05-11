namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    public class Dama : Piece {
        public Dama(ConsoleColor color) : base(color) {
        }
       
     
        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {
            _current = fields[position.Row, position.Column];
            //NO
            var row = position.Row - 1;
            var column = position.Column - 1;
            while (_current.IsValidPosition(row, column) != IsValid()) {
                var field = fields[row, column];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                row--;
                column--;
            }

            // NE
            row = position.Row - 1;
            column = position.Column + 1;
            while (_current.IsValidPosition(row, column) != IsValid()) {
                var field = fields[row, column];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                row--;
                column++;
            }

            //// SE
            row = position.Row + 1;
            column = position.Column + 1;
            while (_current.IsValidPosition(row, column) != IsValid()) {
                var field = fields[row, column];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                row++;
                column++;
            }

            ////SO
            row = position.Row + 1;
            column = position.Column - 1;
            while (_current.IsValidPosition(row, column) != IsValid()) {
                var field = fields[row, column];
                if (field.Piece != null && field.Piece.Color != null && field.Piece.Color.Value == Color) {
                    break;
                }
                field.EnableValidPosition();
                row++;
                column--;
            }

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

        public override string ToString() {
            return " D ";
        }

    }
}
