using BlazorWebApp.Services;

public interface IWeatherService
{
    string[] GetData();

    Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}