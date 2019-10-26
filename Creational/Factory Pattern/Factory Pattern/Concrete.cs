using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Concrete : ManufacturingCompany
    {
        public override IFactory GetFactory(string clientName)
        {
            switch(clientName)
            {
                case "A":
                    return new ClientAFactory();
                case "B":
                    return new ClientBFactory();
                default:
                    throw new ApplicationException(string.Format("Sorry, we can't make this computer!"));
            }
        }
    }
}
