using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii_value
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("13. Show ASCII value of entered number.\nans : \n");
            string str = "ABCDEFGHI";
            
            foreach (var c in str)
            {
                Console.WriteLine((int)c);
            }
            Console.Read();
        }
    }
}
