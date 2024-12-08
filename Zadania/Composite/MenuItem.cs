namespace Composite
{
    public class MenuItem : IMenuComponent
    {
        private readonly string _name;
        private readonly double _price;

        public MenuItem(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Danie: {_name}, Cena: {_price} PLN");
        }
    }
}
