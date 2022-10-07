using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_max_num
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("53. Get 5 values from user and show maximum value from array\nans : ");
            Console.WriteLine("Enter Array.......");
           
            int[] arr = new int[5] ;
            int i, max, min, n;
            for ( i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nArray Element :");
            for ( i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("\nMaximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);

            Console.Read();

        }

    }
}

