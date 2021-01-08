using ObserverWeatherStationDemo.Displays;
using System;

namespace ObserverWeatherStationDemo
{
    /*
     * Observer pattern: defines a one-to-many dependency between objects so that when one object
     * changes state, all its dependents are notified and updated automatically
     */
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
        }
    }
}
