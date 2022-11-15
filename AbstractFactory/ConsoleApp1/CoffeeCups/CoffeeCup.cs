
namespace AbstractFactory.CoffeeCups
{
    public abstract class CoffeeCup
    {
        public abstract string Name { get; }

        public void Print()
        {
            Console.WriteLine("{0}", Name);
        }
    }
}
