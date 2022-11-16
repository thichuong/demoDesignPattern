using System.Collections.Generic;
using AbstractFactory.Coffees;
using AbstractFactory.CoffeeCups;
using AbstractFactory.Factories;

namespace Facade
{
    public class Order
    {
        public Order()
        {
            Drinks = new List<Coffee>();
            Cups = new List<CoffeeCup>();
        }
        public List<Coffee> Drinks { get; set; }
        public List<CoffeeCup> Cups { get; set; }

        public void orderDrink(List<CoffeeName> listDrink)
        {
            Drinks.Clear();
            foreach (CoffeeName drink in listDrink)
            {
                switch (drink)
                {
                    case CoffeeName.HighlandCoffee:
                        this.Drinks.Add(HighlandCoffeeFactory.getInstance().GetCoffee("Highland coffee", 180, 0, 10000));
                        this.Cups.Add(HighlandCoffeeFactory.getInstance().GetCoffeeCup());
                        break;
                    case CoffeeName.HighlandMilkCoffee:
                        this.Drinks.Add(HighlandCoffeeFactory.getInstance().GetCoffee("Highland  milk coffee", 130, 50, 15000));
                        this.Cups.Add(HighlandCoffeeFactory.getInstance().GetCoffeeCup());
                        break;
                    case CoffeeName.TrungNguyenCoffee:
                        this.Drinks.Add(TrungNguyenCoffeeFactory.getInstance().GetCoffee("Trung Nguyen coffee", 180, 0, 12000));
                        this.Cups.Add(TrungNguyenCoffeeFactory.getInstance().GetCoffeeCup());
                        break;
                    case CoffeeName.TrungNguyenMilkCoffee:
                        this.Drinks.Add(TrungNguyenCoffeeFactory.getInstance().GetCoffee("Trung Nguyen milk coffee", 130, 50, 16000));
                        this.Cups.Add(TrungNguyenCoffeeFactory.getInstance().GetCoffeeCup());
                        break;
                    default:
                        this.Drinks.Add(TrungNguyenCoffeeFactory.getInstance().GetCoffee("Trung Nguyen milk coffee", 130, 50, 16000));
                        this.Cups.Add(TrungNguyenCoffeeFactory.getInstance().GetCoffeeCup());
                        break;
                }
            }
            Console.WriteLine("You order: ");

            foreach (var item in this.Drinks)
            {
                Console.Write("     ");
                item.Print();
            }
            Console.WriteLine();
        }

    }
}
