using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace cw
{
    internal class Program
    {

        //public static int getLoopSize(LoopDetector.Node startNode)
        //{
        //    return 0;
        //}

        //static int[] Rotate(int[] nums, int k)
        //{
        //    List<int> result = nums.ToList();

        //    for (int i = 0; i < k; i++)
        //    {
        //        int temp = result[result.Count - 1];
        //        result.Remove(temp);
        //        result.Insert(0,temp);
        //    }
        //    foreach(int i in result)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    nums = result.ToArray();
        //    return nums;
        //}

        public static int LongestSlideDown(int[][] pyramid)
        {
            int[][] max = pyramid;

            for (int y = pyramid.Length - 2; y >= 0; y--)
            {
                for (int x = 0; x < pyramid[y].Length; x++)
                {
                    max[y][x] = pyramid[y][x] + Math.Max(pyramid[y + 1][x], pyramid[y + 1][x + 1]);
                }
            }

            return max[0][0];
        }

        static void Main()
        {
            double a = 0.1;
            double b = 0.2;
            double c = a + b;

            Console.WriteLine("{0,17}", c);

            //int[] vs = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(Rotate(vs, 3)); 

            //VonWegen vonWegen = new VonWegen();
            //vonWegen.IstArsch("Arsch");

            Console.ReadLine();
        }
    }
}