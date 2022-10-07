using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_string_decs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Create program to sort string in descending order.\nans : \n");
            string[] array = new string[3];
            array[0] =  "shivi";
            array[1] = "kataria";
            array[2] = "nidhi";

            Console.WriteLine("sorted string : ");
            array = array.OrderBy(d=>d).ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\nsorted char : ");

            string name = "dishavzxi";
            char[] ary = name.ToCharArray();
            ary = ary.OrderBy(s=>s).ToArray();
            foreach (var item in ary)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
