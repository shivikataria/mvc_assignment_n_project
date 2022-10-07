using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classss
{

    abstract class Test

    {
        public abstract void draw();
    }

    class Test1 : Test
    {
        public override void draw()
        {
            Console.WriteLine("Test1...");
        }
    }

    class Test2 : Test
    {
        public override void draw()
        {
            Console.WriteLine("Test2...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("54. Write a program to define base class with fixed method signature and implement \r\nthem into derived class. (Abstract Class)\nans : \n");
            Test t;
            t = new Test1();
            t.draw();

            t = new Test2();
            t.draw();

            Console.Read();
        }
    }
}
