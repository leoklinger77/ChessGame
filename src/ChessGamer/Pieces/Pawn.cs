namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Pawn : Piece {
        public Pawn(ConsoleColor color) : base(color) {
        }

        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {
            if (fields == null || fields.Length <= 0) {
                throw new ArgumentNullException(nameof(fields));
            }
            var current = fields[position.Row, position.Column];
            var valid = false;
            if (Color == ConsoleColor.White) {
                if (position.Row == 6) {
                    var five = fields[5, position.Column];
                    if (five.Piece == null) {
                        five.EnableValidPosition();
                    }
                    var @for = fields[4, position.Column];
                    if (@for.Piece == null) {
                        @for.EnableValidPosition();
                    }

                    if (@for.ValidPosition || five.ValidPosition) {
                        valid = true;
                    }
                }
                if (position.Row <= 5) {
                    var line = position.Row - 1;
                    if (line >= 0) {

                        var piece = fields[line, position.Column];
                        if (piece.Piece == null) {
                            piece.EnableValidPosition();
                            valid = true;
                        }
                    }
                }


                var columnRight = position.Column + 1;
                var lineResult = position.Row - 1;
                if (columnRight <= 7 && lineResult <= 7) {
                    var fieldRight = fields[lineResult, columnRight];
                    if (fieldRight.Piece != null && fieldRight.Piece.Color != current.Piece.Color) {
                        fieldRight.EnableValidPosition();
                    }
                }

                var columnLeft = position.Column - 1;
                if (columnLeft >= 0 && lineResult >= 0) {
                    var fieldLeft = fields[lineResult, columnLeft];
                    if (fieldLeft.Piece != null && fieldLeft.Piece.Color != current.Piece.Color) {
                        fieldLeft.EnableValidPosition();
                    }
                }
            } else if (Color == ConsoleColor.Yellow) {
                if (position.Row == 1) {
                    fields[2, position.Column].EnableValidPosition();
                    fields[3, position.Column].EnableValidPosition();
                    valid = true;

                    var two = fields[2, position.Column];
                    if (two.Piece == null) {
                        two.EnableValidPosition();
                    }
                    var tree = fields[3, position.Column];
                    if (tree.Piece == null) {
                        tree.EnableValidPosition();
                    }

                    if (tree.ValidPosition || two.ValidPosition) {
                        valid = true;
                    }
                }
                if (position.Row >= 2) {
                    var line = position.Row + 1;
                    if (line <= 7) {
                        var piece = fields[line, position.Column];
                        if (piece.Piece == null) {
                            piece.EnableValidPosition();
                            valid = true;
                        }
                    }
                }
                var columnRight = position.Column + 1;
                var lineResult = position.Row + 1;
                if (columnRight <= 7 && lineResult <= 7) {
                    var fieldRight = fields[lineResult, columnRight];
                    if (fieldRight.Piece != null && fieldRight.Piece.Color != current.Piece.Color) {
                        fieldRight.EnableValidPosition();
                    }
                }

                var columnLeft = position.Column - 1;
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
