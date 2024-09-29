using Builder;

public class Konny : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public string Weapon { get; set; }

    public static readonly List<string> AvailableWeapons = new List<string> { "Lanca", "Szabla", "Miecz" };

    public Konny()
    {
        Name = "Konny";
        Health = 90;
        Attack = 60;
        Defense = 30;
    }

    public override string ToString()
    {
        return $"Profesja: {Name}, Zdrowie: {Health}, Atak: {Attack}, Obrona: {Defense}, Broń: {Weapon}";
    }
}