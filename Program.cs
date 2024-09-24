using System.Text.Json;
namespace JsonSerial;

public class Program
{
    static void Main(string[] args)
    {
        var WeatherForecast = new WeatherForecast
        {
            Date = DateTime.Parse("2024-09-24"),
            TemperatureCelsius = 25,
            Summary = "Hot"
        };
        string fileName = "WeatherForecast.json";
        string jsonString = JsonSerializer.Serialize(WeatherForecast);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine(File.ReadAllText(fileName));
    }
}