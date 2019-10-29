using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    class ConcreteBuilder : HouseType
    {
        public override HouseDirector GetHouseTypes(string housename)
        {
            switch (housename)
            {
                case "hut":
                    return new Hut();
                default:
                    throw new ApplicationException(string.Format("Sorry, we can't make this computer!"));
            }
        }
    }
}
