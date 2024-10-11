using Newtonsoft.Json;
using Prototype;

class Program
{
    static void Main(string[] args)
    {
        Ork originalOrk = new Ork("Garosz", 100, 200);

        // tworzenie kolekcji klonów orków
        List<Ork> orkClones = new List<Ork>();

        for (int i = 0; i < 5; i++)
        {
            // Serializacja oryginalnego obiektu Ork do JSON-a
            string jsonOrk = JsonConvert.SerializeObject(originalOrk);

            // Deserializacja JSON-a do nowego obiektu Ork (klonowanie)
            Ork clonedOrk = JsonConvert.DeserializeObject<Ork>(jsonOrk);
            clonedOrk.Strength = new Random().Next(80, 120);

            // Dodanie klona do kolekcji
            orkClones.Add(clonedOrk);
        }

        foreach (var ork in orkClones)
        {
            Console.WriteLine($"Name: {ork.Name}, Strength: {ork.Strength}, Health: {ork.Health}");
        }
    }
}
