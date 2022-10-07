using System;

namespace fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("question 8 b. 1+1+2+3+5+8+…. ans : \n fibonacci series........... ");

            int a = 0, b = 1, c, x, num;

            Console.WriteLine("Enter the number of element : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(" {0}  terms are :", num);

            Console.Write("{0},{1}", a, b);

            for (x = 2; x < num; x++)
            {
                c = a + b;
                Console.Write(", {0}", c);
                a = b;
                b = c;

            }

            Console.Read();

        }
    }
}
