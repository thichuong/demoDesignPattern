// See https://aka.ms/new-console-template for more information
using System;


namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Pay();

            Console.ReadKey(true);
        }
    }

}