using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBaggageClaimDemo
{
    /// <summary>
    /// Provides information about arriving flights and the carousels where baggage from each flight is available for pickup
    /// </summary>
    public class BaggageInfo
    {
        private int flightNo;
        private string origin;
        private int location;

        internal BaggageInfo(int flight, string from, int carousel)
        {
            this.flightNo = flight;
            this.origin = from;
            this.location = carousel;
        }

        public int FlightNumber => this.flightNo;

        public string From => this.origin;

        public int Carousel => this.location;
    }
}
