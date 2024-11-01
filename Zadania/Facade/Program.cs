
public class Program
{
    public static async Task Main(string[] args)
    {
        string apiKey = "13fd53ace7edceb4c5e4e4e5293454d5";

        // Utworzenie fasady serwisu pogodowego
        WeatherFacade weatherService = new WeatherFacade(apiKey);

        Console.Write("Miejscowość dla której sprawdzamy pogodę: ");
        string city = Console.ReadLine();

        var result = await weatherService.GetCurrentTemperatureAsync(city);

        if (result.HasValue)
        {
            Console.WriteLine($"Temperatura w miejscowości {city} wynosi {result.Value.temperature}°C, ciśnienie {result.Value.pressure}hPa");
        }
        else
        {
            Console.WriteLine("Coś poszło nie tak");
        }
    }
}
