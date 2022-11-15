using AbstractFactory.Coffees;
using AbstractFactory.CoffeeCups;

namespace AbstractFactory.Factories
{
    public interface CoffeeFactory
    {
        Coffee GetCoffee(string Name = "Coffee", int CoffeeContent = 100, int MilkContent = 0, int Price = 10000);

        CoffeeCup GetCoffeeCup();
      
       

    }
}
