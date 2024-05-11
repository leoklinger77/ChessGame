namespace ChessGamer.Tools {
    using ChessGamer.Services;
    using System;

    public static class PieceExtension {
        public static Field GetField(this Field[,] fields, PiecePosition piecePosition) {
            if (piecePosition is null) {
                throw new ArgumentNullException(nameof(piecePosition));
            }
            return fields[piecePosition.Row, piecePosition.Column];
        }
    }
}
