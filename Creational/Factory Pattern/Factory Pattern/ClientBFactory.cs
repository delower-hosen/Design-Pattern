using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class ClientBFactory : IFactory
    {
        public void MakeComputer()
        {
            Console.WriteLine("Client B computer is made.");
        }
    }
}
