using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
        public class Employee
        {
          private string empname;
          private int basicsalary, allowances;
          public double salary;
        public Employee(string empname, int basicsalary, int allowance )
        {
            this.empname = empname;
            this.basicsalary = basicsalary;
            this.allowances = allowance;

        }

        public void total()
        {
            salary = basicsalary + allowances;
             
        }

            public string DisplayValue()
            {
            return $"Employee Details are:  {empname} \n  Basic Salary:{basicsalary} \n  Allowances:{allowances}\n total :{salary} "; 
            }
        }
}
