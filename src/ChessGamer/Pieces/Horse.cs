namespace ChessGamer.Pieces {
    using ChessGamer.Services;

    public class Horse : Piece {
        public Horse(ConsoleColor color) : base(color) {
        }       

        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {
            var current = fields[position.Row, position.Column];
            for (int rrow = 0; rrow < 8; rrow++) {
                for (int ccolumn = 0; ccolumn < 8; ccolumn++) {

                    if (rrow == position.Row - 2 || rrow == position.Row + 2) {
                        if (ccolumn == position.Column + 1 || ccolumn == position.Column - 1) {
                            var fiel = fields[rrow, ccolumn];

                            if (fiel.Piece == null || (fiel.Piece != null && fiel.Piece.Color != current.Piece.Color)) {
                                fiel.EnableValidPosition();
                            }
                        }
                    }

                    if (rrow == position.Row - 1 || rrow == position.Row + 1) {
                        if (ccolumn == position.Column + 2 || ccolumn == position.Column - 2) {
                            var fiel = fields[rrow, ccolumn];
                            if (fiel.Piece == null || (fiel.Piece != null && fiel.Piece.Color != current.Piece.Color)) {
                                fiel.EnableValidPosition();

                            }
                        }
                    }
                }
            }
            return true;
        }

        public override string ToString() {
            return " C ";
        }
    }
}
