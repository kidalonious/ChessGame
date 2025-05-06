using System;

namespace ChessGame.Core
{
    public class Position(int rank, int file)
    {
        public int rank { get; } = rank;
        public int file { get; } = file;

        // override object.Equals
        public override bool Equals(object? obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj is not Position other)
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            return rank == other.rank && file == other.file;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return HashCode.Combine(rank, file);
        }
    }
}