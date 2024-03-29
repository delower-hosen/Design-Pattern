﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    public class Hut : HouseDirector
    {
        private House house;
        public Hut()
        {
            this.house = House.GetHouseInstance;
        }
        public void buildBasement()
        {
            this.house.setBasement("Bamboo");
        }

        public void buildInterior()
        {
            this.house.setInterior("Soil");
        }

        public void buildRoof()
        {
            this.house.setRoof("Straw");
        }

        public void buildWall()
        {
            this.house.setWall("wood");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
