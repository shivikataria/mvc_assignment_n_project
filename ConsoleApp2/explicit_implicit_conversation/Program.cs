using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicit_implicit_conversation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            Console.WriteLine("4. Create a program to differentiate explicit and implicit conversation.\n ans : \n");

            Console.WriteLine("Enter ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID : {0}",id);
            Console.WriteLine("We have converted the Id which is called implicit conversation.");


            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Name : {0}",name);

            Console.WriteLine("We have given value to name without converting it so it is called explicit conversation.");

            Console.Read();
        }
    }
}
