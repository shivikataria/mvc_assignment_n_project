using method_of_overriding;
using System;

namespace method_of_overriding
{
    class employee
    {
        virtual internal void display()
        {
            Console.WriteLine("first class");
        }
    }
     class salaray : employee
    {
        internal void display()
        { 
            Console.WriteLine("secound class ");
        }
       
    
    }


}
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("21. Write a program to perform an example of data hiding?\n");
        Console.WriteLine(" It is used to achieve runtime polymorphism. \n ");
        employee p =new salaray();
        p.display();


        Console.Read();

    }
}

