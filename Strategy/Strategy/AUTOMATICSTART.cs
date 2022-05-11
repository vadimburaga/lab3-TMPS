using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class AutomaticStart : IEngineStart
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine has started as AUTOMATICALLY");
        }
    }
}
