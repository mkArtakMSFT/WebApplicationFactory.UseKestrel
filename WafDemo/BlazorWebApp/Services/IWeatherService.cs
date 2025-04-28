using BlazorWebApp.Services;

public interface IWeatherService
{
    Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}