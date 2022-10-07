using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_student_detail
{

    class student_d
    {
        int id;
        string name;
        string course;
        internal void getdata()
        {
            Console.WriteLine("Enter  ID : ");
            id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :  ");
            name =Console.ReadLine();
            Console.WriteLine("Enter Course : ");
            course = Console.ReadLine(); 
        }
        internal void showdata()
        {
            Console.WriteLine("Student Id : {0}",id);
            Console.WriteLine("Student Name : {0}",name);
            Console.WriteLine("Student Course : {0}",course);         
        }     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Create program to take 5 students details using class \nans : ");
            student_d[] sd = new student_d[5];
            for (int i = 0; i < sd.Length; i++)
            {
                sd[i] = new student_d();
                sd[i].getdata();
            }
            for (int i = 0; i < sd.Length; i++)
            {
               
                sd[i].showdata();
            }

            Console.Read();

        }
    }
}
