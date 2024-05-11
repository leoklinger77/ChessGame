namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    using ChessGamer.Tools;

    public class King : Piece {
        private bool _check = false;
        public King(ConsoleColor color) : base(color) {
        }



        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {



            // #jogadaespecial roque
            if (QtyMove == 0 && !_check) {
                // #jogadaespecial roque pequeno
                PiecePosition posT1 = PiecePosition.Position(position.Row, position.Column + 3);
                if (testeTorreParaRoque(posT1, ref fields)) {
                    PiecePosition p1 = PiecePosition.Position(position.Row, position.Column + 1);
                    PiecePosition p2 = PiecePosition.Position(position.Row, position.Column + 2);
                    if (fields.GetField(p1).Piece == null && fields.GetField(p2).Piece == null) {
                        fields.GetField(p1).EnableValidPosition();
                        fields.GetField(p2).EnableValidPosition();
                    }
                }
                // #jogadaespecial roque grande
                PiecePosition posT2 = PiecePosition.Position(position.Row, position.Column - 4);
                if (testeTorreParaRoque(posT2, ref fields)) {
                    PiecePosition p1 = PiecePosition.Position(position.Row, position.Column - 1);
                    PiecePosition p2 = PiecePosition.Position(position.Row, position.Column - 2);
                    PiecePosition p3 = PiecePosition.Position(position.Row, position.Column - 3);
                    if (fields.GetField(p1).Piece == null && fields.GetField(p2).Piece == null && fields.GetField(p3).Piece == null) {
                        fields.GetField(p1).EnableValidPosition();
                        fields.GetField(p2).EnableValidPosition();
                        //fields.GetField(p3).EnableValidPosition();
                    }
                }
            }
            return true;
        }

        private bool testeTorreParaRoque(PiecePosition pos, ref Field[,] fields) {
            var tower = fields.GetField(pos);

            
            return tower.Piece != null && tower.Piece is Tower && tower.Piece.Color == Color && tower.Piece.QtyMove == 0;
        }

        private void Rock() {
            //_current.Piece.se
        }

        public override string ToString() {
            return " R ";
        }
    }
}
