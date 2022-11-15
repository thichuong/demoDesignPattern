using System;
using AbstractFactory;

namespace AbstractFactory.Coffees
{
    public abstract class Coffee
    {
        public string Name { get; set; }

        public int CoffeeContent { get; set; }

        public int MilkContent { get; set; }

        public int Price { get; set; }

        public abstract string trademark { get; }
       

        public void Print()
        {
            Console.WriteLine("{0} of {1} contains {2} ml coffee and {3} ml milk", Name, trademark, CoffeeContent, MilkContent);
        }
    }
}
