using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWeatherStationDemo.Displays
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData;

        public ForecastDisplay(ISubject _weatherData)
        {
            weatherData = _weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else if (currentPressure < lastPressure)
                Console.WriteLine("Watch out for cooler, rainy weather");
        }

        public void update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }
    }
}
