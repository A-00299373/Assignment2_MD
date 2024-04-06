using WM_System.Factory;
using WM_System.Factory.Interface;

WeatherData weatherData = WeatherData.Instance;

IDisplay currentConditionsDisplay = WeatherStation.CreateDisplay("currentconditions", weatherData);
IDisplay statisticsDisplay = WeatherStation.CreateDisplay("statistics", weatherData);
IDisplay forecastDisplay = WeatherStation.CreateDisplay("forecast", weatherData);

for (int i = 0; i < 3; i++)
{
    weatherData.UpdateWeatherData();
    Console.WriteLine("------------------");
}
