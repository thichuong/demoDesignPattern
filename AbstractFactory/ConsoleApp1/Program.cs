
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            Client client2 = new Client();

            client1.ClientMethod(HighlandCoffeeFactory.getInstance());
            client2.ClientMethod(TrungNguyenCoffeeFactory.getInstance());

            Console.ReadKey(true);
        }
    }
}