using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritancesss
{

    class A
    { 
      internal void first_()
        {
            Console.WriteLine("its class A ");
        }
    
    }
    class B :A
    {
        internal void second_()
        {
            Console.WriteLine("its class B ");

        }

    }
    class C : B 
    {

        internal void third_()
        {
            Console.WriteLine("its class c ");

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("38. Write a program to implement multilevel inheritance.\n ans : ");
            C c = new C();
            c.first_();
            c.second_();
            c.third_();
            Console.Read();
        }
    }
}
