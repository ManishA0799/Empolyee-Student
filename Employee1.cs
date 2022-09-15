using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee1
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee("Manish",25000,5000);
            Console.WriteLine(e1.DisplayValue());
            e1.total();
            
            
           
        }
    }
}
