using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class PaymentService
    {
        public void PaymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal");
        }
        public void PaymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit Card");
        }
        public void PaymentByEBankingAccount()
        {
            Console.WriteLine("Payment by E-banking account");
        }
        public void PaymentByCash()
        {
            Console.WriteLine("Payment by cash");
        }
    }
}
