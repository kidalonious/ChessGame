using System;
namespace ChessGame.Core
{
    public class Piece(PieceType pieceType, Color color)
    {
        public PieceType pieceType = pieceType;
        public Color color = color;
    }
}