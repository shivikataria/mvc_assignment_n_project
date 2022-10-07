using System;
using System.Xml.Schema;

namespace salary_highest
{
    class employee
    {

        string name;
        int salary;
        string department;
        string designation_name;

        internal void getdata()
        {
            Console.WriteLine("Enter Name :  ");
            name = Console.ReadLine();

           Console.WriteLine("Enter department : ");
           department = Console.ReadLine();

            Console.WriteLine("Enter salary  : ");
            salary = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter designation name : ");
           designation_name = Console.ReadLine();
        }
        internal void showdata()

        {
            Console.WriteLine("Employee Name : {0}", name);
            Console.WriteLine("Employee department : {0}", department);
            Console.WriteLine("Employee salary : {0}", salary);
            Console.WriteLine("Employee designation Name : {0}", designation_name);
        }


        internal void salary_detail()
        {
            int n, max;
            n = 3;
            int[] arr = new int[3];

            max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("highest salary is : {0}", max);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("39. Write a program to get 10 Employee details including name, salary, department and show name and designation whose salary is highest.\n ans :  \n");
            employee[] e = new employee[3];
          
            for (int i = 0; i < e.Length; i++)
            {
                e[i] = new employee();
                e[i].getdata();
            }
            for (int i = 0; i < e.Length; i++)
            {
                e[i].showdata();
            }

            employee s = new employee();
            s.salary_detail();
            Console.Read();
        }
    }
}
