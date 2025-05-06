using System;

namespace ChessGame.Core
{
    public class PieceMoves
    {
        // public Dictionary<PieceType, Func<HashSet<Move>>> pieceMap = {PieceType.pawn : this.PawnMoves, PieceType.bishop : this.BishopMoves,
        //                                                 PieceType.rook : this.RookMoves, PieceType.queen : this.QueenMoves,
        //                                                 PieceType.king : this.KingMoves};


        public static HashSet<Move> PawnMoves(Board board, Position startPosition, bool hasMoved)
        {
            Piece piece = board.GetPiece(startPosition);
            int direction;
            switch (piece.color)
            {
                case Color.white:
                    direction = 1;
                    break;
                case Color.black:
                    direction = -1;
                    break;
            }
            if (!hasMoved)
            {
                // Check board at rank + (direction * 2)
            }
            // Check board.squares at rank + direction

            // Check for potential captures at rank + direction, file + and - 1

            // return the filled hashset
            HashSet<Move> validMoves = new HashSet<Move>();
            return validMoves;
        }
        public static HashSet<Move> BishopMoves(Board board, Position startPosition)
        {
            // Check board.squares in rank + and - 1, file + and - 1 until collisions or board edge
            HashSet<Move> validMoves = new HashSet<Move>();
            return validMoves;
        }
        public HashSet<Move> KnightMoves(Board board, Position startPosition)
        {
            // Check board.squares at specific spots rank + and - 2, file + and - 1 and vice versa
            // rank: [ +2, +1, -1, -2 ]
            // file: [ +1, +2, -2, -1 ] match abs(1) in rank with abs(2) in file, abs(2) in rank with abs(1) in file
            HashSet<Move> validMoves = new HashSet<Move>();
            return validMoves;
        }
        public HashSet<Move> RookMoves(Board board, Position startPosition)
        {
            // check board.squares at rank + and - until collision or board edge, then file + and - until collision or board edge
            HashSet<Move> validMoves = new HashSet<Move>();
            return validMoves;
        }
        public HashSet<Move> QueenMoves(Board board, Position startPosition)
        {
            // return the combination of RookMoves and BishopMoves
            // Can use set operator union
            HashSet<Move> validMoves = new HashSet<Move>();
            return validMoves;
        }
        public HashSet<Move> KingMoves(Board board, Position startPosition)
        {
            // Check rank + and - 1, file + and - 1 permutated e.g. rank +, rank -, rank + file +, rank + file - etc

            HashSet<Move> validMoves = new HashSet<Move>();
            return validMoves;
        }

    }
}