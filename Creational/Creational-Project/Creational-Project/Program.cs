using System;

namespace Creational_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string housename = Console.ReadLine();

            House house = ChatroleagueTender.giveTenderToSohomotVai(housename);

            Console.WriteLine("{0} house made!" +
                "using materials\n\n {1} for basement\n {2} for wall\n {3} for roof\n {4} for interior\n",
                housename, house._basement, house._wall, house._roof, house._interior
                );
        }
    }
}
