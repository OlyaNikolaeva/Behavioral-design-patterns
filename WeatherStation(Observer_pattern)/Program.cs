using System.Collections;
using System.Reflection.Metadata.Ecma335;
using WeatherStation_Observer_pattern_.display;
using WeatherStation_Observer_pattern_.displays;
using WeatherStation_Observer_pattern_.interfaces;

namespace WeatherStation_Observer_pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сначала создаем объект WeatherData.
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
