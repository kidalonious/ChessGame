using System;
using ChessGame.Core.Enums;
using ChessGame.Core.Board;

namespace ChessGame.Core.PieceMoves {
    public static class PieceMoves() 
    {
        public Dictionary<PieceType, var> pieceMap = {PieceType.pawn : this.PawnMoves, PieceType.bishop : this.BishopMoves,
                                                        PieceType.rook : this.RookMoves, PieceType.queen : this.QueenMoves, 
                                                        PieceType.king : this.KingMoves};
        public List<Square> PawnMoves(Board board, bool hasMoved, )
        {
            if (!hasMoved && board[]) 
            {

            }
        }
        public List<Square> BishopMoves()
        {

        }
        public List<Square> KnightMoves()
        {

        }
        public List<Square> RookMoves()
        {

        }
        public List<Square> QueenMoves()
        {

        }
        public List<Square> KingMoves()
        {

        }

    }
}