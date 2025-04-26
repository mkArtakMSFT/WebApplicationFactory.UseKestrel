
using BlazorWebApp.Services;

public class TestWeatherService : IWeatherService
{
    public static readonly string[] TestData = ["test one", "test two", "test three"];
    public static string TestWeatherSummary = "Some interesting weather used for test";

    public string[] GetData() => TestData;

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return Task.FromResult(new[]
        {
            new WeatherForecast
            {
                Date = DateOnly.FromDateTime(startDate),
                TemperatureC = 77,
                Summary =  TestWeatherSummary
            }
        });
    }
}
