using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private string name;
        private int std, rollno;

        public Student()
        {
            name = "MAnish Atyalkar";
            std = 9;
            rollno = 15;
        }

        public Student(string name, int std, int rollno)
        {
            this.name = name;
            this.std = std;
            this.rollno = rollno;
        }

        public string DisplayValue()
        {
            return $"Student Details are:  {name}   Std:{std}  Roll NO:{rollno}";
        }




    }
}



















    




