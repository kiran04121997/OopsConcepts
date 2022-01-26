using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Interface
{

        internal class Pig : Interface1
        {
            public void AnimalSound()
            {
                Console.WriteLine("jj");
            }
            public void Sleep()
            {
                Console.WriteLine("zz");
            }
            public void Details()
            {
                Console.WriteLine("aa");
            }
        }
}
