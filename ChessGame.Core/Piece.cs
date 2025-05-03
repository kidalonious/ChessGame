using System;
using ChessGame.Core.Enums;
namespace ChessGame.Core.Piece {
    public class Piece() 
    {
        public PieceType pieceType;
        public Color color;
        public Piece(PieceType pieceType, Color color) 
        {
            this.color = color;
            this.pieceType = pieceType;
        }
    }
}