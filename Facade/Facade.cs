using System;
using System.Collections.Generic;
using AbstractFactory.Coffees;
using AbstractFactory.Factories;

namespace Facade
{
    public class Facade
    {
        

        Order order = new Order
        {            
            Drinks = new List<Coffee>
            {
                HighlandCoffeeFactory.getInstance().GetCoffee("Coffee highland 1",150,0,100),
                HighlandCoffeeFactory.getInstance().GetCoffee("Milk coffee highland 2",100,50,120),
                TrungNguyenCoffeeFactory.getInstance().GetCoffee("Coffee Trung Nguyen",200,0,110),
            }

        public void Pay()
        {
            Calculator calc = new Calculator();
            int sum = calc.Sum(order);
            Console.WriteLine("You paid " + sum);
        }
    }
}
