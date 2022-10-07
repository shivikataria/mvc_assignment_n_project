using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    static class myclass
    {
        public static int id ;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("37. Write a program to call static method using class.\n\n");
           myclass.id = 10;
            Console.WriteLine("{0}",myclass.id);
            Console.Read();
        }
    }
}
