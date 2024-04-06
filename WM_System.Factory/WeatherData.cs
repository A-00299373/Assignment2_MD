using WM_System.Factory.Interface;

namespace WM_System.Factory;

/// <summary>
/// Singleton class for WeatherData that collects weather data and notifies observers.
/// </summary>
public sealed class WeatherData
{
    private static readonly WeatherData instance = new WeatherData();
    private int temperature;
    private int humidity;
    private int pressure;

    private WeatherData() { }

    /// <summary>
    /// Gets the singleton instance of WeatherData.
    /// </summary>
    public static WeatherData Instance
    {
        get { return instance; }
    }

    /// <summary>
    /// Gets and sets the temperature.
    /// </summary>
    public double Temperature
    {
        get { return temperature; }
        private set { temperature = (int)value; }
    }

    /// <summary>
    /// Gets and sets the humidity.
    /// </summary>
    public double Humidity
    {
        get { return humidity; }
        private set { humidity = (int)value; }
    }

    /// <summary>
    /// Gets and sets the pressure.
    /// </summary>
    public double Pressure
    {
        get { return pressure; }
        private set { pressure = (int)value; }
    }

    /// <summary>
    /// Simulates updating weather data.
    /// </summary>
    public void UpdateWeatherData()
    {
        Random random = new Random();
        Temperature = random.NextDouble() * 40 - 10; 
        Humidity = random.NextDouble() * 100; 
        Pressure = random.NextDouble() * 200 + 900; 

        NotifyObservers();
    }

    /// <summary>
    /// Notifies all observers when weather data changes.
    /// </summary>
    private void NotifyObservers()
    {
        WeatherDataChanged?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// Event raised when weather data changes.
    /// </summary>
    public event EventHandler WeatherDataChanged;
}
