using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14. What is jagged array? Explain with example\nans : \n");
            int[][] arr = new int[4][];
            arr[0]=new int[] {9,6,7,8};
            arr[1]=new int[] {9,6,7};
            arr[2]=new int[] {9,6};
            arr[3]=new int[] {9,8,9,7};

            Console.Write("Jagged Array : \n");

            for (int i = 0; i < arr.Length; i++) 
            
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                         Console.Write("{0} ",arr[i][j]);
                    }
                    Console.WriteLine();
                }
            Console.Read();            


        }
    }
}
