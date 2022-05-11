using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class HDD : IO
    {
        private bool isReady = false;

        public bool getStatus() => this.isReady;
        public void initialize()
        {
            Console.WriteLine("Checking Hard Drives...");
            Thread.Sleep(100);
            this.isReady = true;
            Console.WriteLine("Hard Drives are ready...");
            Console.WriteLine("--------------------------");
        }
    }
}
