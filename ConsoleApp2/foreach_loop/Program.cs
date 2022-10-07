using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15. Create program to iterate string variable using foreach loop\n ans : \n");
            ArrayList li = new ArrayList();
            li.Add(1);
            li.Add("shiwani");
            li.Add(2);
            li.Add("zarna");
            foreach (var item in li)
            { 
            
              Console.WriteLine(item);
            
            }
            Console.Read();
        }
    }
}
