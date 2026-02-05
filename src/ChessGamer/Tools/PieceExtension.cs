namespace ChessGamer.Tools {
    using ChessGamer.Services;
    using System;

    public static class PieceExtension {
        public static Field GetField(this Field[,] fields, PiecePosition piecePosition) {
            if (piecePosition is null) {
                throw new ArgumentNullException(nameof(piecePosition));
            }

            if (piecePosition.Row >= fields.GetLength(0) ||
                piecePosition.Column >= fields.GetLength(1) ||
                piecePosition.Row < 0 || 
                piecePosition.Column < 0) {
                return null;
            }

            return fields[piecePosition.Row, piecePosition.Column];
        }
    }
}
