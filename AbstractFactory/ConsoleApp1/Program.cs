
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory HighlandCoffeeFactory1 = HighlandCoffeeFactory.getInstance();
            CoffeeFactory HighlandCoffeeFactory2 = HighlandCoffeeFactory.getInstance();

            CoffeeFactory TrungNguyenCoffeeFactory1 = TrungNguyenCoffeeFactory.getInstance();

            Client client1 = new Client();
            Client client2 = new Client();

            client1.ClientMethod(HighlandCoffeeFactory.getInstance());
            client2.ClientMethod(TrungNguyenCoffeeFactory.getInstance());

           

            Console.ReadKey(true);
        }
    }
}