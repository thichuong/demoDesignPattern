using AbstractFactory.Coffees;


namespace Facade
{
    public class Calculator
    {
        public int Sum(Order order)
        {
            int sum = 0;

            foreach (Coffee drink in order.Drinks)
            {
                sum += drink.Price;
            }

            return sum;
        }
    }
}
