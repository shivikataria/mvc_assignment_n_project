using System;

namespace ConsoleApp2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h, i;
            a = 20;
            b = 40;
            c = a + b;
            d = b - a;
            e = a * b;
            f = b / a;
            g = b % a;
            h = a++;
            i = b--;

            Console.Write("Addition of a and b : {0}\n", c);
            Console.Write("Subtraction of b and a :{0}\n", d);
            Console.WriteLine("Multipication of a and b :{0}", e);
            Console.WriteLine("Division of b and a : {0}", f);
            Console.WriteLine("Mode of a and b : {0}", g);
            Console.WriteLine("Increment of a :{0}", h);
            Console.WriteLine("Decrement of b : {0}", i);


            Console.Read();



        }
    }
}
