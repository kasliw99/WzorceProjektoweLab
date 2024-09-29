namespace Builder
{
    public class PiechurBuilder : WarriorBuilder
    {

        public override void RegisterInArmy()
        {
            warrior = new Piechur();
        }

        public override void EquipWeapon()
        {
            Random random = new Random();
            warrior.Weapon = Piechur.AvailableWeapons[random.Next(Piechur.AvailableWeapons.Count)];
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
