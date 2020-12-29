using System;

namespace ObserverWeatherStationDemo.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject _weatherData)
        {
            weatherData = _weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: "  + temperature
                + "F degrees and " + humidity + "% humidity");
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
