using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{

    partial class myclass
    {
       internal int id;
       internal string name;       
    }
    partial class myclass
    {
        internal void getdata()
        {
            Console.WriteLine("ID : {0}", id);
            Console.WriteLine("Name : {0}", name);

        }
    }

    partial class myclass
    {
        internal void display()
        {

            Console.WriteLine("successful........");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("43. Write a program to divide class definition into multiple parts.\nans : \n");
            myclass m = new myclass();
           
            m.id = 20;
            m.name = "Shiwani";
            m.getdata();
            m.display();
            Console.Read();

        }
    }
}
