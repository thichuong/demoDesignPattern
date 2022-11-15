// See https://aka.ms/new-console-template for more information
using System;


namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.orderDrink(new List<int> { 1,2,2,3,4,1});
            facade.Pay();

            Console.ReadKey(true);
        }
    }

}