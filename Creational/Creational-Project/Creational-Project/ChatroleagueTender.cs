using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    class ChatroleagueTender
    {
        public static House giveTenderToSohomotVai(string input)
        {
            HouseType houseType = new ConcreteBuilder();
            HouseDirector houseDirector = houseType.GetHouseTypes(input);
            BuilderCompany builderCompany = new BuilderCompany(houseDirector);
            builderCompany.constructHouse();
            House house = builderCompany.GetHouse();

            return house;
        }
    }
}
