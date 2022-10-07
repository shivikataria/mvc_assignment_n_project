using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8. Write a program to perform below series and patterns\na. 1+4+9+16+25+…...\nc. 1+5+14+30+55+…..");

            int i, n, sum = 0, choice;

            Console.Write("Enter any case number  :  ");
            choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'a':
                    Console.Write("Enter the number of element  : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n {0}  terms are :", n);
                    for (i = 1; i <= n; i++)
                    {
                        Console.Write("{0}  ", i*i);
                        sum += i * i;
                    }

                    Console.Write("\nThe Sum of Square Natural Number upto {0} terms = {1} \n", n, sum);
                    break;
                case 'b':

                    Console.Write("Enter the number of element  : ");
                    n = Convert.ToInt32(Console.ReadLine());

                    for (i = 1; i <= n; i++)
                    {
                        Console.Write("{0} ", sum);
                        sum += i * i;
                    }
                    Console.Write("\nsum of series num  = {1} \n", n, sum);


                    break;




            }
            Console.Read();


        }
    }
}
