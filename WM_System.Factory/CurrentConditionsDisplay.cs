using WM_System.Factory.Interface;

namespace WM_System.Factory;

/// <summary>
/// Observer for displaying current weather conditions and also acts as a decorator.
/// </summary>
public class CurrentConditionsDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.WeatherDataChanged += WeatherData_WeatherDataChanged;
    }

    private void WeatherData_WeatherDataChanged(object sender, EventArgs e)
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current Weather Conditions:");
        Console.WriteLine($"     Temperature: {weatherData.Temperature}°C");
        Console.WriteLine($"     Humidity: {weatherData.Humidity}%");
        Console.WriteLine($"     Pressure: {weatherData.Pressure}hPa");
        Console.WriteLine($"     Date and Time: {DateTime.Now}");
    }
}



