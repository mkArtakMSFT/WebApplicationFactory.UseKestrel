
using BlazorWebApp.Services;

public class TestWeatherService : IWeatherService
{
    public static string TestWeatherSummary = "Some interesting weather used for test";


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
