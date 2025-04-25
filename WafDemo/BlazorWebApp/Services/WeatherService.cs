
using BlazorWebApp.Services;

public class WeatherService : IWeatherService
{
    public string[] GetData() => ["real one", "real two", "real three"];

    public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        await Task.CompletedTask;

        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(startDate.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }
}