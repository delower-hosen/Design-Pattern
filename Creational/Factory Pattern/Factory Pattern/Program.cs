using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ManufacturingCompany factory = new Concrete();

            Console.WriteLine("Enter client A or B");
            string clientname = Console.ReadLine();
            IFactory ClientAComputer = factory.GetFactory(clientname);
            ClientAComputer.MakeComputer();
        }
    }
}
