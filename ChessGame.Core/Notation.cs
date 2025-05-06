using System;
using System.Collections.Generic;

namespace ChessGame.Core
{
    public static class Notation
    {
        static char[] files = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        public static int[] NotationToPosition(string notation)
        {
            int file = Array.IndexOf(files, notation[0]);
            int rank = Convert.ToInt32(notation[1]);
            return [rank, file];
        }

        public static string PositionToNotation(int[] position)
        {
            int file = position[0];
            return string.Join(file, position[1]);
        }
    }
}