using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class OS : IO
    {
        private bool isReady = false;

        public bool getStatus() => this.isReady;

        public void initialize()
        {
            Console.WriteLine("Operating System is starting...");
            this.isReady = true;
        }
    }
}
