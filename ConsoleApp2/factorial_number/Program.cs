using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_number
{

 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("49. Write a program to find factorial of user defined number\n ans : ");
            int a, b = 1, number;
            Console.Write("Enter any number : ");
            number = int.Parse(Console.ReadLine());
            for (a = 1; a <= number; a++)
            {
                b = b * a;
            }
           Console.Write($"Factorial of   {number} is : {b} " );


            Console.Read();
        }
    }
}
