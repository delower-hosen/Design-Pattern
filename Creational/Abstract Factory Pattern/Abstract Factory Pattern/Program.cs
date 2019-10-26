using System;
using System.Linq;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client A or B?");
            string client = Console.ReadLine();

            IFactory factory;
            if(client == "A")
            {
                factory = new ClientAFactory();
            }
            else if(client == "B")
            {
                factory = new ClientBFactory();
            }
            else
            {
                return;
            }

            var order = new Orders();

            Console.WriteLine("How many computers?");
            order.Computers = ConvertToInt32(Console.ReadLine());

            Console.WriteLine("How many tablets?");
            order.Tablet = ConvertToInt32(Console.ReadLine());

            Console.WriteLine("How many smartphones?");
            order.SmartPhone = ConvertToInt32(Console.ReadLine());

            var company = new ManufacturingCompany(factory);
            company.Produce(order);

            Console.WriteLine("Created " + company.Computers.Count() + " computers.");
            Console.WriteLine("Created " + company.Tablets.Count() + " tablets.");
            Console.WriteLine("Created " + company.SmartPhones.Count() + " smartphones" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                ".");
        }

        private static int ConvertToInt32(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            return Int32.Parse(input);
        }
    }
}
