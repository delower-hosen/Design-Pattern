using System;

namespace Creational_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HouseType houseType = new ConcreteBuilder();

            HouseDirector houseDirector = houseType.GetHouseTypes(input);

            BuilderCompany builderCompany = new BuilderCompany(houseDirector);

            builderCompany.constructHouse();
            House house = builderCompany.GetHouse();

            Console.WriteLine(house._wall);
        }
    }
}
