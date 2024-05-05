namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Pawn : Piece {
        public Pawn(ConsoleColor color) : base(color) {
        }

        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            var current = fields[row, column];
            var valid = false;
            if (Color == ConsoleColor.White) {
                if (row == 6) {
                    var five = fields[5, column];
                    if (five.Piece == null) {
                        five.EnableValidPosition();
                    }
                    var @for = fields[4, column];
                    if (@for.Piece == null) {
                        @for.EnableValidPosition();
                    }

                    if (@for.ValidPosition || five.ValidPosition) {
                        valid = true;
                    }
                }
                if (row <= 5) {
                    var line = row - 1;
                    if (line >= 0) {

                        var piece = fields[line, column];
                        if (piece.Piece == null) {
                            piece.EnableValidPosition();
                            valid = true;
                        }
                    }
                }


                var columnRight = column + 1;
                var lineResult = row - 1;
                if (columnRight <= 7 && lineResult <= 7) {
                    var fieldRight = fields[lineResult, columnRight];
                    if (fieldRight.Piece != null && fieldRight.Piece.Color != current.Piece.Color) {
                        fieldRight.EnableValidPosition();
                    }
                }

                var columnLeft = column - 1;
                if (columnLeft >= 0 && lineResult >= 0) {
                    var fieldLeft = fields[lineResult, columnLeft];
                    if (fieldLeft.Piece != null && fieldLeft.Piece.Color != current.Piece.Color) {
                        fieldLeft.EnableValidPosition();
                    }
                }
            } else if (Color == ConsoleColor.Yellow) {
                if (row == 1) {
                    fields[2, column].EnableValidPosition();
                    fields[3, column].EnableValidPosition();
                    valid = true;

                    var two = fields[2, column];
                    if (two.Piece == null) {
                        two.EnableValidPosition();
                    }
                    var tree = fields[3, column];
                    if (tree.Piece == null) {
                        tree.EnableValidPosition();
                    }

                    if (tree.ValidPosition || two.ValidPosition) {
                        valid = true;
                    }
                }
                if (row >= 2) {
                    var line = row + 1;
                    if (line <= 7) {
                        var piece = fields[line, column];
                        if (piece.Piece == null) {
                            piece.EnableValidPosition();
                            valid = true;
                        }
                    }
                }
                var columnRight = column + 1;
                var lineResult = row + 1;
                if (columnRight <= 7 && lineResult <= 7) {
                    var fieldRight = fields[lineResult, columnRight];
                    if (fieldRight.Piece != null && fieldRight.Piece.Color != current.Piece.Color) {
                        fieldRight.EnableValidPosition();
                    }
                }

                var columnLeft = column - 1;
                if (columnLeft >= 0 && lineResult >= 0) {
                    var fieldLeft = fields[lineResult, columnLeft];
                    if (fieldLeft.Piece != null && fieldLeft.Piece.Color != current.Piece.Color) {
                        fieldLeft.EnableValidPosition();
                    }
                }
            }

            return valid;
        }

        public override string ToString() {
            return " P ";
        }
    }
}
