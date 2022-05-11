using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Observer
{
    class Aircraft
    {
        IObserver[] observers = new IObserver[AircraftParameters.ObserverIndexes.Count];

        BackgroundWorker bgw_checkAcParameters = new BackgroundWorker();

        private int sensorFuelValue = 0;
        private int sensorAltimeter = 0;

        Random rnd = new Random();
        public Aircraft(IObserver[] _observers)
        {
            observers = _observers;
        }

        public void StartBackgroundObserving()
        {
            bgw_checkAcParameters.WorkerReportsProgress = true;
            bgw_checkAcParameters.WorkerSupportsCancellation = true;
            bgw_checkAcParameters.DoWork += Bgw_checkAcParameters_DoWork;
            bgw_checkAcParameters.RunWorkerAsync();
        }

        private void Bgw_checkAcParameters_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                sensorFuelValue = rnd.Next(0, 100);
                sensorAltimeter = rnd.Next(0, 100);
                for (int i = 0; i < observers.Length; i++)
                {
                    if (i == AircraftParameters.ObserverIndexes["FuelObserver"])
                        this.NotifyObserver(observers[AircraftParameters.ObserverIndexes["FuelObserver"]], sensorFuelValue);
                    else if (i == AircraftParameters.ObserverIndexes["AltiudeObserver"])
                        this.NotifyObserver(observers[AircraftParameters.ObserverIndexes["AltiudeObserver"]], sensorFuelValue);
                }
                Thread.Sleep(2000);
            }
        }

        private void NotifyObserver(IObserver _observer, int _value)
        {
            _observer.Update(_value);
        }
    }
}
