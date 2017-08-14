using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_example
{
    class Program
    {
        static IUnityContainer _Container;

        static void Main(string[] args)
        {
            _Container = new UnityContainer();
            new Registry(_Container).Configure();

            _Container.Resolve<Welcome>();
        }
    }
}
