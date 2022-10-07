using System;

namespace inheritance_1
{
    class GFG
    {

        // Function to find the average
        // of a batsman
        static int averageRuns(int runs,
                               int matches,
                               int notout)
        {

            // Calculate number of
            // dismissals
            int out1;
            out1 = matches - notout;

            // Check for 0 times out
            if (out1 == 0)
                return -1;

            // Calculate batting average
            int avg = (runs) / out1;

            return avg;
        }

        // Driver code
        public static void Main(string[] args)
        {
            int runs = 10000;
            int matches = 250;
            int notout = 50;

            int avg = averageRuns(runs, matches,
                                        notout);
            if (avg == -1)
            { Console.Write("NA"); }
            else { 
                Console.Write(avg);
            }
            Console.Read();
        }
           
    }

}