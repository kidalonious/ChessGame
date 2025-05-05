using System;

namespace ChessGame.Core {
    public static class PieceMoves
    {
        Board board;
        int rank;
        int file;
        Piece piece;
        public Dictionary<PieceType, var> pieceMap = {PieceType.pawn : this.PawnMoves, PieceType.bishop : this.BishopMoves,
                                                        PieceType.rook : this.RookMoves, PieceType.queen : this.QueenMoves, 
                                                        PieceType.king : this.KingMoves};

        public PieceMoves(Board board, int rank, int file)
        {
            this.board = board;
            this.rank = rank;
            this.file = file;
            this.piece = this.board.GetPiece(this.rank, this.file);
        }
        public HashSet<Move> PawnMoves( bool hasMoved )
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
        public HashSet<Move> BishopMoves()
        {
            // Check board.squares in rank + and - 1, file + and - 1 until collisions or board edge
            
        }
        public HashSet<Move> KnightMoves()
        {
            // Check board.squares 
        }
        public HashSet<Move> RookMoves()
        {
            // check board.squares at rank + and - until collision or board edge, then file + and - until collision or board edge

        }
        public HashSet<Move> QueenMoves()
        {
            // return the combination of RookMoves and BishopMoves
            // Can use set operator, union
            
        }
        public HashSet<Move> KingMoves()
        {
            // Check rank + and - 1, file + and - 1 permutated e.g. rank +, rank -, rank + file +, rank + file - etc


        }

    }
}