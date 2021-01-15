using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBaggageClaimDemo
{
    /// <summary>
    /// Base class that displays baggage claim information
    /// </summary>
    public class ArrivalsMonitor : IObserver<BaggageInfo>
    {
        private string name;
        private List<string> flightInfos = new List<string>();
        private IDisposable cancellation;
        private string fmt = "{0,-20} {1,5}  {2, 3}";

        public ArrivalsMonitor(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("The observer must be assigned a name.");

            this.name = name;
        }

        /// <summary>
        /// virtual so it can be overridden by a derived class.
        /// </summary>
        /// <param name="provider"></param>
        public virtual void Subscribe(BaggageHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            flightInfos.Clear();
        }

        #region Method Overrides
        public void OnCompleted()
        {
            flightInfos.Clear();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public void OnError(Exception error)
        {
            // No implementation.
        }

        // Update information
        public void OnNext(BaggageInfo info)
        {
            bool updated = false;

            // Flight has unloaded its baggage; remove from the monitor.
            if (info.Carousel == 0)
            {
                var flightsToRemove = new List<string>();
                string flightNo = String.Format("{0,5}", info.FlightNumber);

                foreach (var flightInfo in flightInfos)
                {
                    if (flightInfo.Substring(21, 5).Equals(flightNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                    flightInfos.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
            else
            {
                // Add flight if it does not exist in the collection.
                string flightInfo = String.Format(fmt, info.From, info.FlightNumber, info.Carousel);
                if (!flightInfos.Contains(flightInfo))
                {
                    flightInfos.Add(flightInfo);
                    updated = true;
                }
            }
            if (updated)
            {
                flightInfos.Sort();
                Console.WriteLine("Arrivals information from {0}", this.name);
                foreach (var flightInfo in flightInfos)
                    Console.WriteLine(flightInfo);

                Console.WriteLine();
            }
        }
        #endregion
    }
}
