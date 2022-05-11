using System;

namespace Observer
{
    class Program
    {
        static IObserver[] observers = new IObserver[AircraftParameters.ObserverIndexes.Count];

        static void Main(string[] args)
        {

            
            observers[AircraftParameters.ObserverIndexes["FuelObserver"]] = new FuelObserver();
            observers[AircraftParameters.ObserverIndexes["AltiudeObserver"]] = new AltitudeObserver();

            Aircraft ac = new Aircraft(observers);
            ac.StartBackgroundObserving();

            Console.ReadLine();
        }
    }
}