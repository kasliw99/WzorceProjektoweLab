using Builder;

public class Strzelec : IWarrior
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public string Weapon { get; set; }


    public static readonly List<string> AvailableWeapons = new List<string> { "Łuk", "Kusza" };


    public Strzelec()
    {
        Name = "Strzelec";
        Health = 90;
        Attack = 60;
        Defense = 20;
    }

    public override string ToString()
    {
        return $"Profesja: {Name}, Zdrowie: {Health}, Atak: {Attack}, Obrona: {Defense}, Broń: {Weapon}";
    }
}