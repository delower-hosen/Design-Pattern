using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern
{
    public interface IFactory
    {
        IComputer MakeComputer();
        ITablet MakeTablet();
        ISmartPhone MakeSmartPhone();
    }
}
