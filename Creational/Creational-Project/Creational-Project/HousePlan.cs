using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Project
{
    public interface HousePlan
    {
        public void setBasement(string basement);
        public void setWall(string wall);
        public void setRoof(string roof);
        public void setInterior(string interior);
    }
}
