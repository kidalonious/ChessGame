using System;

namespace ChessGame.Core {
    public class Move {
        public Position startPosition {get;}
        public Position endPosition {get;}
        public PieceType promotionPiece {get;}

        override // override object.Equals
        public override bool Equals(object obj)
        {
            
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return HashCode.Combine(endPosition, startPosition, promotionPiece)
        }
    }
}