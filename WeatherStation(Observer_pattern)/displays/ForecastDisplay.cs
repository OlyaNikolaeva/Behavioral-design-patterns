using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation_Observer_pattern_.interfaces;

namespace WeatherStation_Observer_pattern_.displays
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else if (currentPressure < lastPressure)
                Console.WriteLine("Watch out for cooler, rainy weather");
        }

        public void Update()
        {
            var pressure = weatherData.GetPressure();
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }
    }
}
