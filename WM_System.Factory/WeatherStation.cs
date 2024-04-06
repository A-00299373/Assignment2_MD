using WM_System.Factory.Interface;

namespace WM_System.Factory;

/// <summary>
/// Factory class for creating different types of displays.
/// </summary>
public static class WeatherStation
{
    /// <summary>
    /// Creates a display based on the specified display type.
    /// </summary>
    /// <returns>An instance of the specified display type.</returns>
    public static IDisplay CreateDisplay(string displayType, WeatherData weatherData)
    {
        switch (displayType.ToLower())
        {
            case "currentconditions":
                return new CurrentConditionsDisplay(weatherData);
            case "statistics":
                return new StatisticsDisplay(weatherData);
            case "forecast":
                return new ForecastDisplay(weatherData);
            default:
                throw new ArgumentException("Invalid display type.");
        }
    }
}
