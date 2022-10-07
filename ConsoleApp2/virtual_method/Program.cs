using System;

namespace virtual_method
{
    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base class method is called");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void show()
        {
            Console.WriteLine("DerivedClass method is called");
        }
    }
    class MostDerivedClass : DerivedClass
    {
        public override void show()
        {
            Console.WriteLine("MostDerivedClass  method is called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("59. Write a program to implement virtual method in derived class.\nans : \n");
            BaseClass baseObj;
            MostDerivedClass obj = new MostDerivedClass();
            obj.show();
            baseObj = obj;
            baseObj.show();


            Console.Read();
        }
    }
}
