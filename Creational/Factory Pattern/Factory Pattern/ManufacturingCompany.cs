using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public abstract class ManufacturingCompany
    {
        public abstract IFactory GetFactory(string clientName);
    }
}
