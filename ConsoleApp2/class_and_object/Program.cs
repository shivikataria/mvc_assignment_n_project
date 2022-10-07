    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    class employee
    {
       public int id;
       public string name;
    }
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16. Write a program to call class method.\nans  :  ");
            employee e = new employee();
            e.id = 30;
            e.name = "shiwani";

            Console.WriteLine("Emplyoee Id : {0}",e.id);
            Console.WriteLine("Emplyoee Name : {0}", e.name);


            Console.Read();
        }
    }
}
