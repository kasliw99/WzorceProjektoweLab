public class StrzelecBuilder : WarriorBuilder
{

    public override void RegisterInArmy()
    {
        warrior = new Strzelec();
    }

    public override void EquipWeapon()
    {
        Random random = new Random();
        warrior.Weapon = Strzelec.AvailableWeapons[random.Next(Strzelec.AvailableWeapons.Count)];
    }

    public override void TrainWarrior()
    {
        Random random = new Random();
        warrior.Attack += random.Next(3, 20);
        warrior.Defense += random.Next(3, 20);
        warrior.Health += random.Next(0, 5);
    }
}