using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            IEngineStart engineStart = null;

            Console.WriteLine("Please enter start strategy : ");
            string start_procedure = Console.ReadLine();

            if (start_procedure == "auto")
            {
                engineStart = new AutomaticStart();
            }
            else if (start_procedure == "manual")
            {
                engineStart = new ManualStart();
            }

            engineStart.StartEngine();

            Console.ReadLine();
        }
    }
}