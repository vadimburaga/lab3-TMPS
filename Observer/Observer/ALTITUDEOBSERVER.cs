using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class AltitudeObserver : IObserver
    {

        public void Update(int newvalue)
        {
            AircraftParameters.altitude = newvalue;
            this.Warn();
        }

        public void Warn()
        {
            if (AircraftParameters.altitude < 20)
                Console.WriteLine("ALTITUDE IS CRITICAL.. Altitude is " + AircraftParameters.altitude);
            else
                Console.WriteLine("Altitude is good. ");
        }
    }
}
