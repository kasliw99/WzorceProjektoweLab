using Builder;

public abstract class WarriorBuilder
{
    protected IWarrior warrior;

    public IWarrior GetWarrior() => warrior;

    public abstract void RegisterInArmy();
    public abstract void EquipWeapon();
    public abstract void TrainWarrior();
}