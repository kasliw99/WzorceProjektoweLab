using Builder;

public class Piechur : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public string Weapon { get; set; }

    public static readonly List<string> AvailableWeapons = new List<string> { "Miecz", "Włócznia", "Topór" };

    public Piechur()
    {
        Name = "Piechur";
        Health = 90;
        Attack = 50;
        Defense = 70;
    }

    public override string ToString()
    {
        return $"Profesja: {Name}, Zdrowie: {Health}, Atak: {Attack}, Obrona: {Defense}, Broń: {Weapon}";
    }
}