using AbstractFactory.Coffees;
using AbstractFactory.Coffees;
using AbstractFactory.CoffeeCups;

namespace AbstractFactory.Factories
{
    public class TrungNguyenCoffeeFactory : CoffeeFactory
    {
        public Coffee GetCoffee(string Name, int CoffeeContent, int MilkContent, int Price)
        {
            return new TrungNguyenCoffee(Name, CoffeeContent, MilkContent, Price);
        }
        public CoffeeCup GetCoffeeCup()
        {
            return new TrungNguyenCoffeeCup();
        }

        private static TrungNguyenCoffeeFactory instance = new TrungNguyenCoffeeFactory();

        private TrungNguyenCoffeeFactory()
        {
        }

        public static TrungNguyenCoffeeFactory getInstance()
        {
            if (instance == null)
            {
                instance = new TrungNguyenCoffeeFactory();
            }

            return instance;
        }
    }
}
