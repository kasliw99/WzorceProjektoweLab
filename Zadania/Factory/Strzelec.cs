namespace Factory
{
    internal class Strzelec : IWojownik
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Strzelec(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Profesja: Strzelec, Imię: {Name}, Zdrowie: {Health}, Atak: {Attack}, Obrona: {Defense}";
        }
    }
}
