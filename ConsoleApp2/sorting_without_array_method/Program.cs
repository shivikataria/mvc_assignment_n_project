using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_without_array_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("50. Write a program to sort a numeric array without using array methods.\n ans : ");
            int[] intArray = new int[] { 2, 93, 84, 3, 45, 18, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.Read();


        }
    }
}
