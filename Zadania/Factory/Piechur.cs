namespace Factory
{
    internal class Piechur : IWojownik
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Piechur(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"Profesja: Piechur, Imię: {Name}, Zdrowie: {Health}, Atak: {Attack}, Obrona: {Defense}";
        }
    }
}
