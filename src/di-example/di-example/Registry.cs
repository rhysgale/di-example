using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di_example
{
    class Registry
    {
        private readonly IUnityContainer _Container;

        public Registry(IUnityContainer container)
        {
            _Container = container;
        }

        public void Configure()
        {
            _Container.RegisterType<IGreeting, Greeting>();
            _Container.RegisterType<Welcome>();
        }
    }
}
