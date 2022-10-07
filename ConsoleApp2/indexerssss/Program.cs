using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerssss
{
    class myclass
    {
        string[] name = new string[5];
       public string this[int index]
        { 
         get { 
                return name[index];
            }
            set {
                name[index] = value;
            }
        }    
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("52. Create one collection where can be store all data types by indexing.\nans : \n");
            myclass m = new myclass();
            m[0] = "shiwani";
            m[2] = "saini";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("index : {0}",m[i]);           
            
            }

            Console.Read();

        }
    }
}
