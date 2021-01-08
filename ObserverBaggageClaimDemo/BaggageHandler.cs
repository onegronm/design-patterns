using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverBaggageClaimDemo
{
    /// <summary>
    /// Responsible for receiving information about arriving flights and baggage claim carousels
    /// T: The object that provides notification information. This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived.
    /// </summary>
    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private List<IObserver<BaggageInfo>> observers;
        private List<BaggageInfo> flights;

        public BaggageHandler()
        {
            observers = new List<IObserver<BaggageInfo>>();
            flights = new List<BaggageInfo>();
        }

        // The provider's Subscribe method returns an IDisposable implementation that enables observers to stop receiving notifications
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            // check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // provide the observer with existing data
                foreach (var item in flights)
                    observer.OnNext(item);
            }

            return new Unsubscriber<BaggageInfo>(observers, observer);
        }

        // Called to indicate all baggage is now unloaded.
        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, String.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);

            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !flights.Contains(info))
            {
                flights.Add(info);
                // notify the observers
                foreach (var observer in observers)
                    observer.OnNext(info);
            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done
                var flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in observers)
                            observer.OnNext(info);
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                    flights.Remove(flightToRemove);

                flightsToRemove.Clear();
            }
        }

        /// <summary>
        /// last flight of the day has landed and its baggage has been processed,
        /// This method calls each observer's OnCompleted method to indicate that all notifications have completed, and then clears the observers collection.
        /// </summary>
        public void LastBaggageClaimed()
        {
            foreach (var observer in observers)
                observer.OnCompleted();

            observers.Clear();
        }
    }
}
