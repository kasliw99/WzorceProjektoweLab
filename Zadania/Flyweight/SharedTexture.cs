namespace Flyweight
{
    public class SharedTexture
    {
        // zmienna do przechowywania ścieżki do pliku z teksturą 
        private readonly string _filePath;

        // Konstruktor symulujący ładowanie tekstury z pliku
        public SharedTexture(string filePath)
        {
            _filePath = filePath;
            Console.WriteLine($"Ładowanie tekstury: {_filePath}");
        }
        // Wyświetlenie tekstury w kontekście określonego obiektu
        public void Display(string context)
        {
            Console.WriteLine($"Wyświetlanie tekstury z pliku '{_filePath}' w kontekście: {context}");
        }
    }
}
