using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ans_55_56
{
    abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Called from abstract class");
        }
        public abstract int Area(int length, int breath);
    }
    class Rectangle : Shape
    {
        public override int Area(int length, int breath)
        {
            return length * breath;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("55. Write a program of abstract class with implemented methods and declared methods.\nans : \n");

            Rectangle obj = new Rectangle();
            Console.WriteLine("Enter the length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the brath of rectangle");
            int breath = Convert.ToInt32(Console.ReadLine());
            int area = obj.Area(length, breath);
            Console.WriteLine("Area of rectangle =" + area);
            Console.Read();
        }
    }
}
