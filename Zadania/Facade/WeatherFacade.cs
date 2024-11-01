using Newtonsoft.Json.Linq;

public class WeatherFacade
{
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public WeatherFacade(string apiKey)
    {
        _apiKey = apiKey;
        _httpClient = new HttpClient();
    }
    public async Task<(double temperature, int pressure)?> GetCurrentTemperatureAsync(string city)
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                JObject weatherData = JObject.Parse(jsonResponse);

                double temperature = weatherData["main"]["temp"].Value<double>();
                int pressure = weatherData["main"]["pressure"].Value<int>();
                return (temperature, pressure);
            }
            else
            {
                Console.WriteLine($"Błąd: {response.ReasonPhrase}");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            return null;
        }
    }
}
