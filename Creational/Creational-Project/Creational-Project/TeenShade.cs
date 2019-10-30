using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    public class TeenShade : HouseDirector
    {
        private House house;
        public TeenShade()
        {
            this.house = House.GetHouseInstance;
        }
        public void buildBasement()
        {
            this.house.setBasement("Rod, Cement, Brick");
        }

        public void buildInterior()
        {
            this.house.setInterior("Cement and Sand");
        }

        public void buildRoof()
        {
            this.house.setRoof("Teen");
        }

        public void buildWall()
        {
            this.house.setWall("Brick");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
