namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IWojownik[] soldiers = new IWojownik[10];

            soldiers[0] = Garnizon.TrainSoldier("Piechur", "Andrzej", 100, 40, 60);
            soldiers[1] = Garnizon.TrainSoldier("Piechur", "Zbyszek", 90, 45, 55);
            soldiers[2] = Garnizon.TrainSoldier("Piechur", "Marian", 101, 55, 59);
            soldiers[3] = Garnizon.TrainSoldier("Konny", "Marek", 98, 88, 20);
            soldiers[4] = Garnizon.TrainSoldier("Konny", "Gienek", 85, 90, 30);
            soldiers[5] = Garnizon.TrainSoldier("Konny", "Bogdan", 100, 88, 15);
            soldiers[6] = Garnizon.TrainSoldier("Strzelec", "Janek", 83, 98, 37);
            soldiers[7] = Garnizon.TrainSoldier("Strzelec", "Kamil", 90, 99, 21);
            soldiers[8] = Garnizon.TrainSoldier("Strzelec", "Tomek", 100, 92, 33);
            soldiers[9] = Garnizon.TrainSoldier("Strzelec", "Kamil", 90, 98, 30);

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
