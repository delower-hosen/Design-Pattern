using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    class Duplex : HouseDirector
    {
        private House house;
        public Duplex()
        {
            this.house = House.GetHouseInstance;
        }
        public void buildBasement()
        {
            this.house.setBasement("Rod, Cement");
        }

        public void buildInterior()
        {
            this.house.setInterior("Tiles");
        }

        public void buildRoof()
        {
            this.house.setRoof("Rock");
        }

        public void buildWall()
        {
            this.house.setWall("Dami brick");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
