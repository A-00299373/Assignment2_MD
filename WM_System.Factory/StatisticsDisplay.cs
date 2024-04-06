using WM_System.Factory.Interface;

namespace WM_System.Factory;
/// <summary>
/// Observer for displaying weather statistics.
/// </summary>
public class StatisticsDisplay : IDisplay
{
    private readonly WeatherData weatherData;
    private readonly List<double> temperatureData = new List<double>();

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

    public void Display()
    {
        Console.WriteLine("Weather Statistics:");
        Console.WriteLine($"     Average Temperature: {CalculateAverageTemperature()}°C");
        Console.WriteLine($"     Max Temperature: {CalculateMaxTemperature()}°C");
        Console.WriteLine($"     Min Temperature: {CalculateMinTemperature()}°C");
    }

    private double CalculateAverageTemperature()
    {
        if (temperatureData.Count == 0)
            return 0;

        return (int)temperatureData.Average();
    }

    private double CalculateMaxTemperature()
    {
        if (temperatureData.Count == 0)
            return 0;

        return (int)temperatureData.Max();
    }

    private double CalculateMinTemperature()
    {
        if (temperatureData.Count == 0)
            return 0;

        return (int)temperatureData.Min();
    }
}

