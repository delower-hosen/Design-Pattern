using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public class ClientAFactory : IFactory
    {
        public IComputer MakeComputer()
        {
            return new ClientAComputer();
        }

        public ISmartPhone MakeSmartPhone()
        {
            return new ClientASmartPhone();
        }

        public ITablet MakeTablet()
        {
            return new ClientATablet();
        }
    }
}
