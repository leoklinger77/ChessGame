namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Pawn : Piece {
        public Pawn(ConsoleColor color) : base(color) {
        }

        internal override bool FieldAttacked(int row, int column, ref Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            if (Color == ConsoleColor.White) {
                var columnRight = column + 1;
                var lineResult = row - 1;
                if (columnRight <= 7 && lineResult <= 7) {
                    var fieldRight = fields[lineResult, columnRight];
                    if (fieldRight.Piece != null) {
                        fieldRight.EnableFieldAttacked();
                    }
                }

                var columnLeft = column - 1;
                if (columnLeft >= 0 && lineResult >= 0) {
                    var fieldLeft = fields[lineResult, columnLeft];
                    if (fieldLeft.Piece != null) {
                        fieldLeft.EnableFieldAttacked();
                    }
                }
            } else if (Color == ConsoleColor.Yellow) {
                var columnRight = column + 1;
                var lineResult = row + 1;
                if (columnRight <= 7 && lineResult <= 7) {
                    var fieldRight = fields[lineResult, columnRight];
                    if (fieldRight.Piece != null) {
                        fieldRight.EnableFieldAttacked();
                    }
                }

                var columnLeft = column - 1;
                if (columnLeft >= 0 && lineResult >= 0) {
                    var fieldLeft = fields[lineResult, columnLeft];
                    if (fieldLeft.Piece != null) {
                        fieldLeft.EnableFieldAttacked();
                    }
                }
            }
            return true;
        }

        internal override bool ValidFilds(int row, int column, ref Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            var descLine = 0;
            var valid = false;
            if (Color == ConsoleColor.White) {
                if (row == 6) {
                    var one = fields[5, column];
                    var two = fields[4, column];
                    one.EnableValidPosition();
                    two.EnableValidPosition();
                    valid = true;
                }
                if (row <= 5) {
                    descLine = row - 1;
                    if (descLine >= 0) {
                        fields[descLine, column].EnableValidPosition();
                        valid = true;
                    }
                }
            } else if (Color == ConsoleColor.Yellow) {
                if (row == 1) {
                    fields[2, column].EnableValidPosition();
                    fields[3, column].EnableValidPosition();
                    valid = true;
                }
                if (row >= 2) {
                    descLine = row + 1;
                    if (descLine <= 7) {
                        var fiel = fields[descLine, column];
                        if (fiel.Piece == null) {
                            fiel.EnableValidPosition();
                            valid = true;
                        }
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
