using Builder;

public class Garnizon
{
    private WarriorBuilder _warriorBuilder;

    public void SetWarriorBuilder(WarriorBuilder builder)
    {
        _warriorBuilder = builder;
    }

    public IWarrior TrainWarrior()
    {
        _warriorBuilder.RegisterInArmy();
        _warriorBuilder.EquipWeapon();
        _warriorBuilder.TrainWarrior();
        return _warriorBuilder.GetWarrior();
    }
}