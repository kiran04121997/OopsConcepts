using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Polymorphism.Method_Over_riding
{
    internal class PartTimeEmployee:Employee

    {
        public void GetSalary()
        {
            Console.WriteLine("Salary is 250");

        }
    }
}
