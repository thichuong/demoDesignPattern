using AbstractFactory.Coffees;
using AbstractFactory.CoffeeCups;

namespace AbstractFactory.Factories
{
    public class HighlandCoffeeFactory : CoffeeFactory
    {
        public Coffee GetCoffee(string Name, int CoffeeContent, int MilkContent, int Price)
        {
            return new HighlandCoffee(Name, CoffeeContent, MilkContent, Price);
        }
        public CoffeeCup GetCoffeeCup()
        {
            return new HighlandCoffeeCup();
        }

        private static HighlandCoffeeFactory instance = new HighlandCoffeeFactory();

        private HighlandCoffeeFactory()
        {
        }

        public static HighlandCoffeeFactory getInstance()
        {
            if (instance == null)
            {
                instance = new HighlandCoffeeFactory();
            }

            return instance;
        }
    }
}
