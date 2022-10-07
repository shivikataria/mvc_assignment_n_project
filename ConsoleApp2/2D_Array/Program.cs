using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int[,] arr = new int[3, 3];
            int[] arry = new int[5];
            int i, j, temp;

            Console.WriteLine("32. What do you mean by multi-dimension array?\n\n");
            Console.WriteLine("Enter array number ");
            for ( i = 0; i < 2; i++)
            {
                for ( j = 0; j < 2; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array element :  ");
             for ( i = 0; i < 2; i++)
            {
                for ( j = 0; j < 2; j++)
                {

                    if (arry[i] > arry[j])
                    {
                        temp = arry[i];
                        arry[i] = arry[j];
                        arry[j] = temp;
                    }   

                    
                    Console.Write("{0} ",arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
