using System;
using System.Collections.Generic;

namespace ChessGame.Core.Notation {
    public static class Notation
    {
        static string[8] files = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
        public int[] NotationToPosition(string notation) 
        {
            int file = files.IndexOf(notation[0]);
            int rank = Convert.ToInt32(notation[1]);
            return [rank, file];
        }

        public string PositionToNotation(int[2] position) 
        {
            string file = position[1]
            return string.Join(file, position[1]);
        }
    }
}