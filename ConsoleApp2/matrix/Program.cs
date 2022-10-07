using System;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("35. Create program to make Transpose of two matrices\nans : \n");
            int m, n, i, j;
            Console.Write("Enter the Order of the Matrix : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose Matrix : ");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[j, i] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }

}

