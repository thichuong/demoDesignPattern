namespace AbstractFactory.Coffees
{
    public class HighlandCoffee : Coffee
    {
        public HighlandCoffee(string Name, int CoffeeContent, int MilkContent, int Price)
        {
            this.Name = Name;
            this.CoffeeContent = CoffeeContent;
            this.MilkContent = MilkContent;
            this.Price = Price;
        }
        public override string trademark
        {
            get { return "Highland Coffee"; }
        }

    }
}
