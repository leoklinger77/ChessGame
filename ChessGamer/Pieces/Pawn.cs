namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Pawn : Piece {
        public Pawn(PieceColor color) : base(color) {
        }

        internal override bool FieldAttacked(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            if (Color == PieceColor.White) {
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
            } else if (Color == PieceColor.Black) {
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

        internal override bool ValidFields(int line, int column, Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            var descLine = 0;
            var valid = false;
            if (Color == PieceColor.White) {
                // White pawns move up (decreasing line number)
                if (line == 6) {
                    // Starting position - can move 1 or 2 squares
                    if (fields[5, column].Piece == null) {
                        fields[5, column].EnableValidPosition();
                        valid = true;
                        // Can move 2 squares only if first square is also empty
                        if (fields[4, column].Piece == null) {
                            fields[4, column].EnableValidPosition();
                        }
                    }
                } else if (line > 0) {
                    // Normal move - one square forward
                    descLine = line - 1;
                    if (fields[descLine, column].Piece == null) {
                        fields[descLine, column].EnableValidPosition();
                        valid = true;
                    }
                }
            } else if (Color == PieceColor.Black) {
                // Black pawns move down (increasing line number)
                if (line == 1) {
                    // Starting position - can move 1 or 2 squares
                    if (fields[2, column].Piece == null) {
                        fields[2, column].EnableValidPosition();
                        valid = true;
                        // Can move 2 squares only if first square is also empty
                        if (fields[3, column].Piece == null) {
                            fields[3, column].EnableValidPosition();
                        }
                    }
                } else if (line < 7) {
                    // Normal move - one square forward
                    descLine = line + 1;
                    if (fields[descLine, column].Piece == null) {
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
