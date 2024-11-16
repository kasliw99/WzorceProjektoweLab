using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz rodzaj pliku:");
            Console.WriteLine("1 - Plik publiczny");
            Console.WriteLine("2 - Plik zastrzeżony");

            string choice = Console.ReadLine();
            IFiles file;

            switch (choice)
            {
                case "1":
                    file = new PublicFile();
                    file.AccessFile();
                    break;
                case "2":
                    file = new FileProxy();
                    file.AccessFile();
                    break;
                default:
                    Console.WriteLine("Brak danego pliku");
                    break;
            }
        }
    }
}
