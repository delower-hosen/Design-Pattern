using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    public class BuilderCompany
    {
        private HouseDirector _houseDirector;
        public BuilderCompany(HouseDirector houseDirector)
        {
            _houseDirector = houseDirector;
        }

        public void constructHouse()
        {
            _houseDirector.buildBasement();
            _houseDirector.buildWall();
            _houseDirector.buildRoof();
            _houseDirector.buildInterior();
        }

        public House GetHouse()
        {
            return _houseDirector.getHouse();
        }
    }
}
