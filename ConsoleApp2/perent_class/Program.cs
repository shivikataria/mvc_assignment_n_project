using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perent_class
{
    class employee
    {
        int emp_id;
        string emp_name;
        internal void getdata()
        {
            Console.WriteLine("Enter Id : ");
            emp_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            emp_name = Console.ReadLine();         
        }
        internal void showdata()
        { 
           Console.WriteLine("employee id : {0}", emp_id);
           Console.WriteLine("employee name :{0} ",emp_name);         
        }
    }

    class payroll : employee
    {
        int salary;
        internal void getpayroll()
        {
            getdata();
            Console.WriteLine("Enter salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void showpayroll()
        { 
            showdata();
          Console.WriteLine("employee salary : {0}",salary);        
        
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("18. Write a program to call method of parent class.\nans : \n");
            
            payroll p = new payroll();
            p.getpayroll();
            p.showpayroll();

            Console.Read();

        }
    }
}
