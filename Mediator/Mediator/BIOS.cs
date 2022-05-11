using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class BIOS
    {
        public void pressPowerButton()
        {
            CPU _cpu = new CPU();
            _cpu.initialize();
            if (_cpu.getStatus() == false)
                Console.WriteLine("Starting CPU is failed...");

            RAM _ram = new RAM();
            _ram.initialize();
            if (_ram.getStatus() == false)
                Console.WriteLine("Starting RAM is failed...");

            HDD _hdd = new HDD();
            _hdd.initialize();
            if (_hdd.getStatus() == false)
                Console.WriteLine("Starting HDD is failed...");

            if (_cpu.getStatus() && _ram.getStatus() && _hdd.getStatus())
            {
                OS _os = new OS();
                _os.initialize();
                if (_os.getStatus() == true)
                    Console.WriteLine("Operating System started successfully...");
            }
        }
    }
}
