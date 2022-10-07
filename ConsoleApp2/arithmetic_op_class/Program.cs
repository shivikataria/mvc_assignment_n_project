using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_op_class
{
    class arithmetic_opration
    {
        public int a=10,b=20,c,d,e,f,g,h,i;
        public void getdata()
        {            
            c = a + b;
            d = b - a;
            e = a * b;
            f = b / a;
            g = b % a;
            h = a++;
            i = b--; 
        }
        public void displaydata()
        {
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}",b);
            Console.Write("Addition of a and b : {0}\n", c);
            Console.Write("Subtraction of b and a :{0}\n", d);
            Console.WriteLine("Multipication of a and b :{0}", e);
            Console.WriteLine("Division of b and a : {0}", f);
            Console.WriteLine("Mode of a and b : {0}", g);
            Console.WriteLine("Increment of a :{0}", h);
            Console.WriteLine("Decrement of b : {0}", i);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17. Write a program to calculate arithmetic operations using class and object.\nans  : \n");
            arithmetic_opration o = new arithmetic_opration();           
            o.getdata();
            o.displaydata();
           

            Console.Read();



        }
    }
}
