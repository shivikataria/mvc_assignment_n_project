using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12. What is Array?\n ans : \n");
            int[] arr=new int[5];
              Console.WriteLine("Enter Array.......");
              for (int i = 0; i < arr.Length; i++)
              {
                  arr[i]=Convert.ToInt32(Console.ReadLine());

              }
              Console.WriteLine("\nArray Element :");
              for (int i = 0; i < arr.Length; i++)
              {
                  Console.Write("{0} ", arr[i]);

              }
            Console.Read();


        }
    }
}
