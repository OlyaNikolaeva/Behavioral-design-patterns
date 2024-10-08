﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation_Observer_pattern_.interfaces;

namespace WeatherStation_Observer_pattern_.displays
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        float heatIndex = 0.0f;
        private WeatherData weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            var temp = weatherData.GetTemperature();
            var rh = weatherData.GetHumidity();
            heatIndex = ComputeHeatIndex(temp, rh);
            Display();
        }

        private float ComputeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public void Display()
        {
            Console.WriteLine("Heat index is " + heatIndex);
        }
    }
}
