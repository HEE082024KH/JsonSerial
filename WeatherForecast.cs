using System.Text.Json;
namespace JsonSerial;

public class WeatherForecast
{
  public DateTimeOffset Date { get; set; }
  public int TemperatureCelsius { get; set; }
  public string? Summary { get; set; }
}