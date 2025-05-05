using System;
using ChessGame.Core;
namespace ChessGame.Core {
    public class Board {
        Piece[,] squares = new Piece[8,8];
        public Piece GetPiece(int rank, int file)
        {
            return this.squares[rank - 1, file - 1];
        }
        public void SetSquare(int rank, int file, Piece piece)
        {
            this.squares[rank - 1, file - 1] = piece;
        }
    }
}