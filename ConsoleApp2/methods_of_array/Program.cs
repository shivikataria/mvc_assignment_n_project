using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 80, 20, 30, 12, 89, 34, 1, 3, 0, 8 };

            Console.WriteLine("33. Explain 5 method of array class with example \n\n");
            Console.Write("Array : ");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            Console.Write("Sorted Array : ");

            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");

            }   
            Console.WriteLine();

            Console.Write("Reverse Array : ");

            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Copied Array :  ");
            int[] brr = new int[10];

            Array.Copy(arr, brr, 5);
            foreach (int i in brr)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
