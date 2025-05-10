using System;
using System.Text.RegularExpressions;
namespace ChessGame.Core
{
    public class Piece(PieceType pieceType, Color color)
    {
        public PieceType pieceType = pieceType;
        public Color color = color;

        public HashSet<Move> pieceMoves(Board board, Position startPosition) {
            HashSet<Move> moves = new HashSet<Move>();
            switch (pieceType) {
                case PieceType.pawn:
                    moves = PawnMoves(board, startPosition);
                    break;
                case PieceType.bishop:
                    moves = BishopMoves(board, startPosition);
                    break;
                case PieceType.knight:
                    moves = KnightMoves(board, startPosition);
                    break;
                case PieceType.rook:
                    moves = RookMoves(board, startPosition);
                    break;
                case PieceType.queen:
                    moves = QueenMoves(board, startPosition);
                    break;
                case PieceType.king:
                    moves = KingMoves(board, startPosition);
                    break;
                default:
                    break;

            }
            return moves;
        }

        public static HashSet<Move> PawnMoves(Board board, Position startPosition)
        {
            HashSet<Move> validMoves = new HashSet<Move>();
            Piece piece = board.GetPiece(startPosition);
            int direction = 1;
            switch (piece.color)
            {
                case Color.white:
                    direction = 1;
                    break;
                case Color.black:
                    direction = -1;
                    break;
            }
            if ((piece.color == Color.black && startPosition.rank == 7) || (piece.color == Color.white && startPosition.rank == 2) &&
                    board.squares[startPosition.rank + (direction * 2), startPosition.file] == null) 
            {
                validMoves.Add(new Move(startPosition, new Position(startPosition.rank + (direction * 2), startPosition.file)));
            }
            Position checkSquare = new Position(startPosition.rank + direction, startPosition.file);
            // Check board.squares at rank + direction
            if (board.GetPiece(checkSquare) == null)
            {
                validMoves.Add(new Move(startPosition, checkSquare));
            }
            // Check for potential captures at rank + direction, file + and - 1
            Position[] checkCaptures = [
                new Position(startPosition.rank + direction, startPosition.file + 1), 
                new Position(startPosition.rank + direction, startPosition.file - 1)];
            
            foreach (Position captureSquare in checkCaptures)
            {
                if (board.GetPiece(captureSquare) != null && board.GetPiece(captureSquare).color != piece.color)
                {
                    validMoves.Add(new Move(startPosition, captureSquare));
                }
            }
            // return the filled hashset
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