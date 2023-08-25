namespace DotnetRepositoryPattern.Data.Models;

public class Weather
{
    public long WeatherId { get; set; }
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(100 / 0.5556);

    public string? Summary { get; set; }
}