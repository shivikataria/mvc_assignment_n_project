using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_to_outside
{
    class pto
    {
        int a=10;
      public void datavalue()
        {
            Console.WriteLine("value of a : {0}",a);
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("42. Write a program to access private variables outside of class.\nans: \n");

            pto p = new pto();
            
            p.datavalue();
            
            
            
            Console.Read();

        }
    }
}
