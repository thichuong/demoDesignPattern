using System.Collections.Generic;
using AbstractFactory.Coffees;


namespace Facade
{
    public class Order
    {
        public List<Coffee> Drinks { get; set; }

        public void addDrink(Coffee coffee)
        {
            Drinks.Add(coffee);
        }
    }
}
