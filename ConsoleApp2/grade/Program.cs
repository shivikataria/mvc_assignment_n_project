using System;

namespace grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, math;
            float total, percentage;

            Console.WriteLine("19. Write a program to get three subject marks details and then show average and sum.\n\n");
            Console.Write("Enter Marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks of Chemistry : ");
            chem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks of Maths : ");
            math = Convert.ToInt32(Console.ReadLine());

            total = phy + chem + math;
            percentage = total / 3;


            Console.WriteLine("physics = {0}", phy);
            Console.WriteLine("Chemistry = {0}", chem);
            Console.WriteLine("Maths = {0}", math);
            Console.Write("Total Marks of all subject : {0}\n", total);
            Console.WriteLine("Percentage : {0}", percentage);

            if (percentage >= 80)
            {
                Console.WriteLine("First Division....");
            }

            else if (percentage >= 70)
            {
                Console.WriteLine("Second Division....");
            }

            else if (percentage >= 50)
            {
                Console.WriteLine("Third Division....");
            }


            else
            {
                Console.WriteLine("Fail........");
            }





            Console.Read();




        }
    }
}
