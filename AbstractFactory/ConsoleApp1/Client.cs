using System;
using AbstractFactory.Coffees;
using AbstractFactory.Coffees;
using AbstractFactory.CoffeeCups;
using AbstractFactory.Factories;


namespace AbstractFactory
{
    public class Client
    {
        Coffee Coffee;
        CoffeeCup CoffeeCup;

        public void ClientMethod(CoffeeFactory factory)
        {
            Coffee = factory.GetCoffee();
            CoffeeCup = factory.GetCoffeeCup();
            Coffee.Print();
            CoffeeCup.Print();


        }
    }
}
