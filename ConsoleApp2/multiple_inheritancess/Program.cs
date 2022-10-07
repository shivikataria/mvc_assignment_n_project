using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritancess
{
    interface Iemployee
    {
        void getdata();
        void showdata();
    
    }
    class employee : Iemployee
    {
        public void getdata()
        {
            Console.WriteLine("GETDATA.........");
        }
        public void showdata()
           {
            Console.WriteLine("SHOWDATA.........");
           }
    }

    

    /* class A
     {
         internal void first_()
         {            Console.WriteLine("its class A ");        }
     }
     class B : A
     {        internal void second_()
         {            Console.WriteLine("its class B ");        }
     }
     class C : A   {        internal void third_()
         {            Console.WriteLine("its class c ");           }
     }*/


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("40. Write a program to implement multiple inheritance.\n ans : C# does not support multiple class inheritance." +
                "\n To overcome this problem we use interfaces to achieve multiple class inheritance. With the help of the interface, class C can get the features of class A and B.");

            Iemployee e = new employee();
            e.getdata();
            e.showdata();
            
            
                  
            
            
            
            
            
            // C c = new C();
            //c.first_();
            //  c.second_();
            // c.third_();


            Console.Read();
        }
    }
}
