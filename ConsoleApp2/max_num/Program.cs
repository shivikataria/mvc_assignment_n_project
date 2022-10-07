using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("7. Create program to take 2 numbers from user and show maximum number\n\n");

            Console.WriteLine("Enter two  number  ......");
            a = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Enter a number ......");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("value of a : {0},\nvalue of b : {1}", a, b);
            if (a > b)
            {
                Console.Write("maximum number is : {0}", a);

            }
            else
            {
                Console.Write("maximum number is : {0}", b);

            }

            Console.Read();



        }
    }
}
