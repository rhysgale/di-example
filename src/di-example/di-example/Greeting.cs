using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_example
{
    class Greeting : IGreeting
    {
        public void Greet()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
