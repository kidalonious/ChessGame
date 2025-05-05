using System;

namespace ChessGame.Core {
    public static class PieceMoves
    {
        public Dictionary<PieceType, var> pieceMap = {PieceType.pawn : this.PawnMoves, PieceType.bishop : this.BishopMoves,
                                                        PieceType.rook : this.RookMoves, PieceType.queen : this.QueenMoves, 
                                                        PieceType.king : this.KingMoves};

        
        public HashSet<Move> PawnMoves( Board board, Position startPosition, bool hasMoved )
        {
            int direction;
            switch ( this.piece.pieceType ) 
            {
                case white:
                direction = 1
                break;
                case black:
                direction = -1
                break;
            }
            if (!hasMoved) 
            {
                // Check board at rank + (direction * 2)
            }
            // Check board.squares at rank + direction

            // Check for potential captures at rank + direction, file + and - 1

        }
        public HashSet<Move> BishopMoves( Board board, Position startPosition )
        {
            // Check board.squares in rank + and - 1, file + and - 1 until collisions or board edge
            
        }
        public HashSet<Move> KnightMoves( Board board, Position startPosition )
        {
            // Check board.squares 
        }
        public HashSet<Move> RookMoves( Board board, Position startPosition )
        {
            // check board.squares at rank + and - until collision or board edge, then file + and - until collision or board edge

        }
        public HashSet<Move> QueenMoves( Board board, Position startPosition )
        {
            // return the combination of RookMoves and BishopMoves
            // Can use set operator union
            
        }
        public HashSet<Move> KingMoves( Board board, Position startPosition )
        {
            // Check rank + and - 1, file + and - 1 permutated e.g. rank +, rank -, rank + file +, rank + file - etc


        }

    }
}