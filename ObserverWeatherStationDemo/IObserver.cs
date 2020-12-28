using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverWeatherStationDemo
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}
