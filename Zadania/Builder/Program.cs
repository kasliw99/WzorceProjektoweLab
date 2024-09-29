using Builder;

class Program
{
    static void Main(string[] args)
    {
        Garnizon garnizon = new Garnizon();
        List<IWarrior> warriors = new List<IWarrior>();

        WarriorBuilder piechurBuilder = new PiechurBuilder();
        garnizon.SetWarriorBuilder(piechurBuilder);
        warriors.Add(garnizon.TrainWarrior());
        warriors.Add(garnizon.TrainWarrior());

        WarriorBuilder konnyBuilder = new KonnyBuilder();
        garnizon.SetWarriorBuilder(konnyBuilder);
        warriors.Add(garnizon.TrainWarrior());
        warriors.Add(garnizon.TrainWarrior());

        WarriorBuilder strzelecBuilder = new StrzelecBuilder();
        garnizon.SetWarriorBuilder(strzelecBuilder);
        warriors.Add(garnizon.TrainWarrior());
        warriors.Add(garnizon.TrainWarrior());

        foreach (var warrior in warriors)
        {
            Console.WriteLine(warrior);
        }
    }
}