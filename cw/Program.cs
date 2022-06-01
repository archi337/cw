using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace cw
{
    internal class Program
    {
        //public static string formatDuration(int seconds)
        //{
        //    string[] vs = new string[5];
        //    vs[4] = " second";
        //    vs[3] = " minute";
        //    vs[2] = " day";
        //    vs[1] = " week";
        //    vs[0] = " year";


        //    int[] time = new int[5];
        //    time[4] = seconds % 60;
        //    time[3] = (seconds / 60) % 60;
        //    time[2] = ((seconds / 60) / 60) % 24;
        //    time[1] = (((seconds / 60) / 60) / 24) % 365;
        //    time[0] = ((((seconds / 60) / 60) / 24) / 365);

        //    string answer = "";

        //    for (int i = 4; i >= 0; i--)
        //    {
        //        if (time[i] == 0)
        //        {

        //        }

        //        else
        //        {
        //            if (time[i] == 1)
        //            {
        //                answer += time[i] + vs[i];
        //            }
        //            answer += time[i] + vs[i] + "s";
        //        }
        //    }
        //    Console.WriteLine(answer);
        //    return answer;
        //}

        public static bool ValidateSolution(int[,] board)
        {
            int valid1 = 45;
            int valid2 = 45;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                int test1 = 0;
                int test2 = 0;
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    test1 += board[i, j];
                    test2 += board[j, i];
                }
                if (test1 != valid1 || test2 != valid2) return false;

                var block = new List<int>();
                int br = (i / 3) * 3;
                int bc = (i % 3) * 3;
                for (int j = 0; j < 9; ++j) block.Add(board[br + j / 3,bc + j % 3]);
                if (!ValidateNine(block)) return false;

            }
            return true;
        }

        private static int[] nineNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private static bool ValidateNine(IList<int> nine)
        {
            return nineNumbers.All(nine.Contains);
        }



        static void Main()
        {
            int[,] board1 =
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2},
                {6, 7, 2, 1, 9, 5, 3, 4, 8},
                {1, 9, 8, 3, 4, 2, 5, 6, 7},
                {8, 5, 9, 7, 6, 1, 4, 2, 3},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6},
                {9, 6, 1, 5, 3, 7, 2, 8, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 4, 5, 2, 8, 6, 1, 7, 9}
            };

            int[,] board2 =
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2},
                {6, 7, 2, 1, 9, 5, 3, 4, 8},
                {1, 9, 8, 3, 0, 2, 5, 6, 7},
                {8, 5, 0, 7, 6, 1, 4, 2, 3},
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 0, 3, 9, 2, 4, 8, 5, 6},
                {9, 6, 1, 5, 3, 7, 2, 8, 4},
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 0, 0, 2, 8, 6, 1, 7, 9}
            };

            int[,] board3 =
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9},
                {2, 3, 1, 5, 6, 4, 8, 9, 7},
                {3, 1, 2, 6, 4, 5, 9, 7, 8},
                {4, 5, 6, 7, 8, 9, 1, 2, 3},
                {5, 6, 4, 8, 9, 7, 2, 3, 1},
                {6, 4, 5, 9, 7, 8, 3, 1, 2},
                {7, 8, 9, 1, 2, 3, 4, 5, 6},
                {8, 9, 7, 2, 3, 1, 5, 6, 4},
                {9, 7, 8, 3, 1, 2, 6, 4, 5}
            };

            Console.WriteLine(ValidateSolution(board1));

            //int test = 101956166;
            //formatDuration(test);

            Console.ReadLine();
        }
    }
}
