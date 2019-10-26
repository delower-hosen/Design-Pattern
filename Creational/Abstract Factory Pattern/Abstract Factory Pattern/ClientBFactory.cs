using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    class ClientBFactory : IFactory
    {
        public IComputer MakeComputer()
        {
            return new ClientBComputer();
        }

        public ISmartPhone MakeSmartPhone()
        {
            return new ClientBSmartPhone();
        }

        public ITablet MakeTablet()
        {
            return new ClientBTablet();
        }
    }
}
