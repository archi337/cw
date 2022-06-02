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
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";

            string[] vs = new string[5];
            vs[4] = " second";
            vs[3] = " minute";
            vs[2] = " hour";
            vs[1] = " day";
            vs[0] = " year";


            int[] time = new int[5];
            time[4] = seconds % 60;
            time[3] = (seconds / 60) % 60;
            time[2] = ((seconds / 60) / 60) % 24;
            time[1] = (((seconds / 60) / 60) / 24) % 365;
            time[0] = ((((seconds / 60) / 60) / 24) / 365);

            string answer = "";

            var counter = time.Where(x => x != 0).Count() - 1;
            Console.WriteLine(counter);



            for (int i = 0; i <= 4; i++)
            {
                if (time[i] == 0)
                {

                }
                else
                {
                    if (time[i] == 1)
                    {
                        if (counter > 1) answer += time[i] + vs[i] + ", ";
                        else if (counter == 1) answer += time[i] + vs[i] + " and ";
                        else answer += time[i] + vs[i];

                        counter--;
                    }
                    else
                    {
                        if (counter > 1) answer += time[i] + vs[i] + "s, ";
                        else if (counter == 1) answer += time[i] + vs[i] + "s and ";
                        else answer += time[i] + vs[i] + "s ";

                        counter--;
                    }
                }
            }
            Console.WriteLine(answer);
            return answer;
        }



        static void Main()
        {

            int test = 3662;
            formatDuration(test);

            VonWegen vonWegen = new VonWegen();
            vonWegen.IstArsch("Arsch");

            Console.ReadLine();
        }
    }
}