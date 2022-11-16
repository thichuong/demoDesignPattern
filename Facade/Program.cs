// See https://aka.ms/new-console-template for more information
using System;


namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CafeFacade facade = CafeFacade.getInstance();
            List<CoffeeName> drinks = new List<CoffeeName> { CoffeeName.TrungNguyenMilkCoffee, CoffeeName.HighlandMilkCoffee };

            facade.orderDrink(drinks);
         
            facade.Pay(PaymentBy.PaymentByCash);

            Console.ReadKey(true);
        }
    }

}