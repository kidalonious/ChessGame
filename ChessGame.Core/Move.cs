using System;

namespace ChessGame.Core {
    public class Move {
        public Position startPosition {get;}
        public Position endPosition {get;}
        public PieceType promotionPiece {get;}

        public Move(Position startPosition, Position endPosition, PieceType? promotionPiece = null)
        {
            this.startPosition = startPosition;
            this.endPosition = endPosition;
            this.promotionPiece = promotionPiece;
        }

        override // override object.Equals
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            if (obj is not Move move) return false;

            return Equals(endPosition, move.endPosition) &&
            Equals(startPosition, move.startPosition) &&
            Equals(promotionPiece, move.promotionPiece);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return HashCode.Combine(endPosition, startPosition, promotionPiece)
        }
    }
}