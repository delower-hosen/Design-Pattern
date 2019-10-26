using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class ClientAFactory : IFactory
    {
        public void MakeComputer()
        {
            Console.WriteLine("Client A computer is made.");
        }
    }
}
