using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public static class AircraftParameters
    {
        public static Dictionary<string, int> ObserverIndexes = new Dictionary<string, int> {
                { "FuelObserver", 0 }, { "AltiudeObserver", 1 }
            };


        public static int fuelQuantity = 0;
        public static int altitude = 0;
    }
}
