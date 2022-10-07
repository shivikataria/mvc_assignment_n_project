using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array_element
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 6 };

            Console.WriteLine("34. Get 5 values from user and store in array and show all elements and sum of elements \n ans : ");

            Console.Write("array elements : ");

            for (int i = 0; i < arr.Length; i++)
            { 
            
             Console.Write("{0} ",arr[i]); 
            
            }

            int sum = arr.Sum();
            Console.WriteLine("\nsum of array elements : {0}",sum);

            Console.Read();
        }
    }
}
