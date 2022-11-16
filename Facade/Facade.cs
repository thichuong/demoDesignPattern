using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AbstractFactory.Coffees;
using AbstractFactory.Factories;

namespace Facade
{
    public enum PaymentBy
    {
        PaymentByPaypal,
        PaymentByCreditCard,
        PaymentByEBankingAccount,
        PaymentByCash
    }
    public enum CoffeeName
    {
        HighlandCoffee,
        HighlandMilkCoffee,
        TrungNguyenCoffee,
        TrungNguyenMilkCoffee
    }
    public class CafeFacade
    {

        Calculator calc;
        Order order ;
        PaymentService paymentService;

        public void orderDrink(List<CoffeeName> listDrink)
        {
            order.orderDrink(listDrink);            
        }
        public void Pay(PaymentBy paymentBy)
        {
            int sum = calc.Sum(order);
            Console.WriteLine("You paid " + sum + " VND");
            switch (paymentBy)
            {
                case PaymentBy.PaymentByPaypal:
                    paymentService.PaymentByPaypal();
                    break;                    
                case PaymentBy.PaymentByCash:
                    paymentService.PaymentByCash();
                    break; 
                case PaymentBy.PaymentByCreditCard:
                    paymentService.PaymentByCreditCard();
                    break; 
                case PaymentBy.PaymentByEBankingAccount:
                    paymentService.PaymentByEBankingAccount();
                    break; 
                default:
                    paymentService.PaymentByCash();
                    break;
            }
        }
       
        private static CafeFacade instance = new CafeFacade();

        private CafeFacade()
        {
            calc = new Calculator();
            order = new Order();
            paymentService = new PaymentService();
        }

        public static CafeFacade getInstance()
        {
            if (instance == null)
            {
                instance = new CafeFacade();
            }
            return instance;
        }
    }
}
