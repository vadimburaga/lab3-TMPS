using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class RAM : IO
    {
        private bool isReady = false;

        public bool getStatus() => this.isReady;

        public void initialize()
        {
            Console.WriteLine("Checking System Memory...");
            Thread.Sleep(100);
            this.isReady = true;
            Console.WriteLine("System Memory is ready...");
            Console.WriteLine("--------------------------");
        }
    }
}
