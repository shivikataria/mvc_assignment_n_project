using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_num_find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("28. Create program to take 3 numbers from user and show maximum and minimum . \n\n");

            Console.WriteLine("Enter three  number  ......");
            a = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Enter a number ......");
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value of a : {0},\nvalue of b : {1},\nvalue of c : {2}", a, b,c);
            if ((a >b) && (a > c))
            {
                Console.WriteLine("maximum number is : {0}", a);

            }
            else if (c > a && c > b)
            {
                Console.WriteLine("maximum number is : {0}", c);

            }
            else
            {
                Console.WriteLine("maximum number is : {0}", b);

            }

            if ((a < b) && (a < c))
            {
                Console.WriteLine("minimum number is : {0}", a);

            }
            else if (c < a && c < b)
            {
                Console.WriteLine("minimum number is : {0}", c);

            }
            else
            {
                Console.WriteLine("minimum number is : {0}", b);

            }

            Console.Read();



        }
    }
}
