using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_example
{
    public class Welcome
    {
        public Welcome(IGreeting message)
        {
            message.Greet();
        }
    }
}
