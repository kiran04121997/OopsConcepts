using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Abstraction
{
    internal class Tiger:AnimalAbstract
    {
        public override void AnimalSound1()
        {
            Console.WriteLine("Abstract method");

        }
    }
}
