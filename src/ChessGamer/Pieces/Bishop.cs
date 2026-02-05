namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Bishop : Piece {
        public Bishop(ConsoleColor color) : base(color) {
        }

        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {
            _current = fields[position.Row, position.Column];
            //NO
            var row = position.Row - 1;
            var column = position.Column - 1;
            while (_current.IsValidPosition(row, column) != IsValid()) {
                var field = fields[row, column];
                if (!CanMove(field)) {
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
                if (!CanMove(field)) {
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
                if (!CanMove(field)) {
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
                if (!CanMove(field)) {
                    break;
                }
                field.EnableValidPosition();
                row++;
                column--;
            }
            return true;
        }       

        public override string ToString() {
            return " B ";
        }
    }
}
