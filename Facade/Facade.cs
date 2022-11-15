using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AbstractFactory.Coffees;
using AbstractFactory.Factories;

namespace Facade
{
    public class Facade
    {

        Calculator calc;
        Order order ;

        public void orderDrink(List<int> listDrink)
        {
            order = new Order
            {
                Drinks = new List<Coffee>()                
            };

            foreach (int drink in listDrink)
            {
                switch (drink)
                {
                    case 1:
                        order.addDrink(HighlandCoffeeFactory.getInstance().GetCoffee("Highland coffee", 150, 0, 10000));
                        break;
                        break;
                    case 2:
                        order.addDrink(HighlandCoffeeFactory.getInstance().GetCoffee("Highland  milk coffee", 150, 50, 15000));
                        break;
                    case 3:
                        order.addDrink(TrungNguyenCoffeeFactory.getInstance().GetCoffee("Trung Nguyen coffee", 180, 0, 12000));
                        break;
                    case 4:
                        order.addDrink(TrungNguyenCoffeeFactory.getInstance().GetCoffee("Trung Nguyen milk coffee", 180, 50, 16000));
                        break;
                    default:
                        order.addDrink(TrungNguyenCoffeeFactory.getInstance().GetCoffee("Trung Nguyen milk coffee", 180, 50, 16000));
                        break;
                }
            }

            Console.WriteLine("You order: ");

            foreach (var item in order.Drinks)
            {
                Console.Write("     ");
                item.Print();
            }
            Console.WriteLine();

        }
        public void Pay()
        {
            calc = new Calculator();
            int sum = calc.Sum(order);
            Console.WriteLine("You paid " + sum + " VND");
        }
    }
}
