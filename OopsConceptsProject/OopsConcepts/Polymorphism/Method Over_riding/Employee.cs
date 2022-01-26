using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism.Method_Over_riding
{
    internal class Employee
    {
        public string name;
        public double salary;

        public void EmployeeDetails()
        {
            Console.WriteLine("name:" + name);
        }
        public void GetSalary()
        {
            Console.WriteLine("SALARY:500");

        }
    }
}
