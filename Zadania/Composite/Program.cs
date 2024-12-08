namespace Composite
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie dań
            var burger = new MenuItem("Burger", 25.00);
            var pizza = new MenuItem("Pizza Hawajska", 30.00);
            var salad = new MenuItem("Sałatka Grecka", 20.00);

            // Tworzenie kategorii
            var mainCourse = new MenuCategory("Dania Główne");
            var starters = new MenuCategory("Przystawki");

            // Dodawanie dań do kategorii
            mainCourse.Add(burger);
            mainCourse.Add(pizza);
            starters.Add(salad);

            // Tworzenie menu głównego
            var mainMenu = new MenuCategory("Menu Główne");
            mainMenu.Add(starters);
            mainMenu.Add(mainCourse);

            // Wyświetlenie całego menu
            Console.WriteLine("Całe Menu:");
            mainMenu.Display();
        }
    }

}