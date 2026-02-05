namespace ChessGamer.Pieces {
    using ChessGamer.Services;
    using ChessGamer.Tools;
    using System.Drawing;

    public class King : Piece {
        private bool _check = false;

        public King(ConsoleColor color) : base(color) {
        }

        internal override bool ValidFilds(PiecePosition position, ref Field[,] fields) {

            //cima
            var top = fields.GetField(PiecePosition.Position(position.Row - 1, position.Column));
            if (top != null && CanMove(top)) {
                top.EnableValidPosition();
            }

            //baixo
            var bottom = fields.GetField(PiecePosition.Position(position.Row + 1, position.Column));
            if (bottom != null && CanMove(bottom)) {
                bottom.EnableValidPosition();
            }

            //direita
            var right = fields.GetField(PiecePosition.Position(position.Row, position.Column + 1));
            if (right != null && CanMove(right)) {
                right.EnableValidPosition();
            }

            //esquerda
            var left = fields.GetField(PiecePosition.Position(position.Row, position.Column - 1));
            if (left != null && CanMove(left)) {
                left.EnableValidPosition();
            }

            // #jogadaespecial roque
            if (QtyMove == 0 && !_check) {
                // #jogadaespecial roque pequeno
                var t1 = PiecePosition.Position(position.Row, position.Column + 3);
                if (TowerValidForRock(t1, ref fields)) {
                    PiecePosition p1 = PiecePosition.Position(position.Row, position.Column + 1);
                    PiecePosition p2 = PiecePosition.Position(position.Row, position.Column + 2);
                    if (fields.GetField(p1).Piece == null && fields.GetField(p2).Piece == null) {
                        fields.GetField(p1).EnableValidPosition();
                        fields.GetField(p2).EnableValidPosition();
                    }
                }
                // #jogadaespecial roque grande
                var t2 = PiecePosition.Position(position.Row, position.Column - 4);
                if (TowerValidForRock(t2, ref fields)) {
                    PiecePosition p1 = PiecePosition.Position(position.Row, position.Column - 1);
                    PiecePosition p2 = PiecePosition.Position(position.Row, position.Column - 2);
                    PiecePosition p3 = PiecePosition.Position(position.Row, position.Column - 3);
                    if (fields.GetField(p1).Piece == null && fields.GetField(p2).Piece == null && fields.GetField(p3).Piece == null) {
                        fields.GetField(p1).EnableValidPosition();
                        fields.GetField(p2).EnableValidPosition();
                    }
                }
            }
            return true;
        }

        private bool TowerValidForRock(PiecePosition pos, ref Field[,] fields) {
            var tower = fields.GetField(pos);

            return tower.Piece != null && tower.Piece is Tower && tower.Piece.Color == Color && tower.Piece.QtyMove == 0;
        }

        public override string ToString() {
            return " R ";
        }
    }
}
