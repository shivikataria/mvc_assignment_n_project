using System;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int year;


            Console.WriteLine("Enter any year....");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)

            {

                Console.WriteLine("Entered year is a leap year.");
            }

            else
            {
                Console.WriteLine("Entered year is not  a leap year.");
            }

            Console.Read();
        }
    }
}
