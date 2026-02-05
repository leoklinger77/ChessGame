namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Pawn : Piece {
        public Pawn(ConsoleColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, ref Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            if (Color == ConsoleColor.White) {
                var columnRight = column + 1;
                var lineResult = line - 1;
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
                var lineResult = line + 1;
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

        internal override bool ValidFilds(int line, int column, ref Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            var descLine = 0;
            var valid = false;
            if (Color == ConsoleColor.White) {
                if (line == 6) {
                    fields[5, column].EnableValidPosition();
                    fields[4, column].EnableValidPosition();
                    valid = true;
                }
                if (line <= 5) {
                    descLine = line - 1;
                    if (descLine >= 0) {
                        fields[descLine, column].EnableValidPosition();
                        valid = true;
                    }
                }
            } else if (Color == ConsoleColor.Yellow) {
                if (line == 1) {
                    fields[2, column].EnableValidPosition();
                    fields[3, column].EnableValidPosition();
                    valid = true;
                }
                if (line >= 2) {
                    descLine = line + 1;
                    if (descLine <= 7) {
                        fields[descLine, column].EnableValidPosition();
                        valid = true;
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
