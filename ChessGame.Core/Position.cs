using System;

namespace ChessGame.Core {
    public class Position {
        public int rank {get;}
        public int file {get;}
        public Position(int rank, int file) 
        {
            this.rank = rank;
            this.file = file;
        }
    }
}