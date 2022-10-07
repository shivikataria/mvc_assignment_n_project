using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascending_order
{
    class parent_
    {
        
          internal void getdata() 
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 56, 876, 01 };

            for (int i = 0; i < 11 ; i++)
            {
                Console.Write(" {0}", arr[i]);
                arr = arr.OrderByDescending(c=>c).ToArray();
            }
            
        }
    }

    class drive_ : parent_
    {
        internal void adddata()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 56, 876, 01 };
            Console.WriteLine("\nascending order : ");
            arr = arr.OrderBy(c => c).ToArray();

            foreach (int value in arr)
            {
             Console.Write(value + " ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("57. Write a program to Get 10 random numbers using parent class's constructor and implement one method in derived class to show them in ascending manner.\n ans : \n");
            Console.WriteLine("numbers ........");
            drive_  p = new drive_ ();
            p.getdata();
            p.adddata();
            

            Console.Read();

        }
    }
}
