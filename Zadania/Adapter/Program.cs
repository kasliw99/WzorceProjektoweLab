namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj wiek");
            int age = int.Parse(Console.ReadLine());

            var newPerson = new Teenager(age);
            if (newPerson.IsAdult()) 
            {
                Console.WriteLine($"{name} jest dorosły, może wejść do klubu");
            } else
            {
                Console.WriteLine($"{name} nie jest dorosły, zakaz wstępu");
                var fakeAdult = new FakeAdult(newPerson);
                Console.WriteLine(fakeAdult.IsAdult() ? $"jednak wszystko się zgadza, {name} może wejść do klubu" : $"nope, {name} nie może wejsć");
            }
        }
    }
}
