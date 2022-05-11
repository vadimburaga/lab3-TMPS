using System;


namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            BIOS _bios = new BIOS();
            _bios.pressPowerButton();

            Console.ReadLine();
        }
    }
}