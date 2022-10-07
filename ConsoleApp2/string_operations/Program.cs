using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("47. Create program to replace specific character from string\nans : ");

            string str = " String Operations in C# ";
               
            Console.Write("This is orignal string : ");
            Console.WriteLine(str);

            // 27 .Create program to replace specific word from string
            Console.Write("Replaced string  :  ");
            Console.WriteLine(str.Replace("Operations ", " Replace method  "));

         /*  
            Console.Write("lenght of string : ");
            Console.WriteLine(str.Length);

            
            Console.WriteLine(str.Contains("ing"));

            Console.Write("string end  with dot : ");
            Console.WriteLine(str.EndsWith("."));

            Console.Write("string start with space : ");
            Console.WriteLine(str.StartsWith(" "));

            Console.Write("what is first index of g : ");
            Console.WriteLine(str.IndexOf('g'));

            Console.Write("what is last index of r : ");
            Console.WriteLine(str.LastIndexOf('r'));

            Console.Write("methods word insert in string  : ");
            Console.WriteLine(str.Insert(19," methods "));
           
            // Console.WriteLine(str.PadLeft(30,*));
            //Console.WriteLine(str.PadRight(30,*));

            Console.Write("string in upper case  : ");
            Console.WriteLine(str.ToUpper());

            Console.Write("string in lower case  : ");
            Console.WriteLine(str.ToLower()); */



            Console.Read();





        }
    }
}
