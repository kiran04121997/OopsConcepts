using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    abstract class AnimalAbstract
    {
        public abstract void AnimalSound1();
        public void sleep()
        {
            Console.WriteLine("Non abstract method");
        }
    }
}
