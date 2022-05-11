using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class CPU : IO
    {
        private bool isReady = false;

        public bool getStatus() => this.isReady;

        public void initialize()
        {
            Console.WriteLine("Checking CPU...");
            Thread.Sleep(100);
            this.isReady = true;
            Console.WriteLine("CPU is ready...");
            Console.WriteLine("--------------------------");
        }
    }
}
