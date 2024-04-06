using WM_System.Factory.Interface;

namespace WM_System.Factory;
/// <summary>
/// Observer for displaying weather forecast.
/// </summary>
public class ForecastDisplay : IDisplay
{
    private readonly WeatherData weatherData;

    public ForecastDisplay(WeatherData weatherData)
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
        double currentTemperature = weatherData.Temperature;
        Random random = new Random();

        if (currentTemperature < 0)
        {
            Console.WriteLine("Weather Forecast:Expecting cold weather. Snowfall possible.");
        }
        else if (currentTemperature >= 0 && currentTemperature < 10)
        {
            Console.WriteLine("Weather Forecast:Cool weather expected. Light jacket may be needed.");
        }
        else if (currentTemperature >= 10 && currentTemperature < 20)
        {
            Console.WriteLine("Weather Forecast:Mild weather expected. Enjoy the pleasant temperature!");
        }
        else if (currentTemperature >= 20 && currentTemperature < 30)
        {
            Console.WriteLine("Weather Forecast:Warm weather expected. Sunscreen recommended.");
        }
        else
        {
            Console.WriteLine("Weather Forecast:Hot weather expected. Stay hydrated.");
        }
    }
}


