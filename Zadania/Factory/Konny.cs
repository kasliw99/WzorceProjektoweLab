namespace Factory
{
    internal class Konny : IWojownik
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Konny(string name, int health, int attack, int defense) 
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Profesja: Konny, Imię: {Name}, Zdrowie: {Health}, Atak: {Attack}, Obrona: {Defense}";
        }
    }
}
