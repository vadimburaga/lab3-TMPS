using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class FuelObserver : IObserver
    {
        public void Update(int newvalue)
        {
            AircraftParameters.fuelQuantity = newvalue;
            this.Warn();
        }

        public void Warn()
        {
            if (AircraftParameters.fuelQuantity < 30)
                Console.WriteLine("FUEL LEVEL IS CRITICAL.. Fuel Level is " + AircraftParameters.fuelQuantity);
            else
                Console.WriteLine("Fuel Level is good ");
        }
    }
}
