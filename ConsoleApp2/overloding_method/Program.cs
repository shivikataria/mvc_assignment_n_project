using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloding_method
{
    class priya
    {
        internal void sum(int a)
        {
            Console.WriteLine($"sum of to num : {a+a}");
        }
        internal void sum(int a , int b)
        {
            Console.WriteLine($"sum of to num : {a + b}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("41. Write a program to redefine method logic in child class. (Overloading)\n ans : \n");
            priya p = new priya();
            p.sum(68);
            p.sum(45,67);
            Console.Read();

        }
    }
}
