using WM_System.Factory.Interface;

namespace WM_System.Factory;
/// <summary>
/// Observer for displaying weather statistics.
/// </summary>
public class StatisticsDisplay : IDisplay
{
    private readonly WeatherData weatherData;
    private readonly List<double> temperatureData = new List<double>();

    /// <summary>
    /// Initializes a new instance of the <see cref="StatisticsDisplay"/> class.
    /// </summary>
    /// <param name="weatherData"></param>
    public StatisticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.WeatherDataChanged += WeatherData_WeatherDataChanged;
    }

    private void WeatherData_WeatherDataChanged(object sender, EventArgs e)
    {
        temperatureData.Add(weatherData.Temperature);
        Display();
    }

    /// <summary>
    /// Displays the weather statistics including average, maximum, and minimum temperatures.
    /// </summary>
    public void Display()
    {
        Console.WriteLine("Weather Statistics:");
        Console.WriteLine($"     Average Temperature: {CalculateAverageTemperature()}°C");
        Console.WriteLine($"     Max Temperature: {CalculateMaxTemperature()}°C");
        Console.WriteLine($"     Min Temperature: {CalculateMinTemperature()}°C");
    }

    private int CalculateAverageTemperature()
    {
        if (temperatureData.Count == 0)
            return 0;

        return (int)temperatureData.Average();
    }

    private int CalculateMaxTemperature()
    {
        if (temperatureData.Count == 0)
            return 0;

        return (int)temperatureData.Max();
    }

    private int CalculateMinTemperature()
    {
        if (temperatureData.Count == 0)
            return 0;

        return (int)temperatureData.Min();
    }
}

