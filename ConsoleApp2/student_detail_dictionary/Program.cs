using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_detail_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("61. Create a program to store student’s details using Dictionary\nans : ");

            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Student_id ", "101");
            d.Add("Name", "Shiwani");
            d.Add("Department", "MVC");


            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            Console.Read();

        }
    }
}
