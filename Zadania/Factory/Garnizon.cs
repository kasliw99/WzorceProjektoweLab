namespace Factory
{
    internal class Garnizon
    {
        public static IWojownik TrainSoldier(string profession, string name, int health, int attack, int defense)
        {
            IWojownik iwojownik = null;

            switch (profession.ToLower())
            {
                case "konny":
                    {
                        iwojownik = new Konny(name, health, attack, defense);
                        break;
                    }
                case "piechur":
                    {
                        iwojownik = new Piechur(name, health, attack, defense);
                        break;
                    }
                case "strzelec":
                    {
                        iwojownik = new Strzelec(name, health, attack, defense);
                        break;
                    }
                default:
                    {
                        iwojownik = new Konny(name, health, attack, defense);
                        break;
                    }
            }

            return iwojownik;
        }
    }
}

