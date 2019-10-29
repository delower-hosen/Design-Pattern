using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    public interface HouseDirector
    {
        public void buildBasement();
        public void buildWall();
        public void buildRoof();
        public void buildInterior();
        public House getHouse();
    }
}
