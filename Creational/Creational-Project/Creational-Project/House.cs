using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    public class House : HousePlan
    {
        public string _basement, _wall, _roof, _interior;
        public void setBasement(string basement)
        {
            _basement = basement;
        }

        public void setInterior(string interior)
        {
            _interior = interior;
        }

        public void setRoof(string roof)
        {
            _roof = roof;
        }

        public void setWall(string wall)
        {
            _wall = wall;
        }
    }
}
