namespace Builder
{
    public class KonnyBuilder : WarriorBuilder
    {

        public override void RegisterInArmy()
        {
            warrior = new Konny();
        }

        public override void EquipWeapon()
        {
            Random random = new Random();
            warrior.Weapon = Konny.AvailableWeapons[random.Next(Konny.AvailableWeapons.Count)];
        }

        public override void TrainWarrior()
        {
            Random random = new Random();
            warrior.Attack += random.Next(3, 20);
            warrior.Defense += random.Next(3, 20);
            warrior.Health += random.Next(0, 5);
        }
    }
}
