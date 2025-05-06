using System;

namespace ChessGame.Core
{
    public class Board
    {
        public Piece[,] squares = new Piece[8, 8];
        public Piece GetPiece(Position position)
        {
            return this.squares[position.rank - 1, position.file - 1];
        }
        public void SetSquare(Position position, Piece piece)
        {
            this.squares[position.rank - 1, position.file - 1] = piece;
        }
    }
}