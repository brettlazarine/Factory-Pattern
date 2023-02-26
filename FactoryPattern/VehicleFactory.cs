using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle()
        {
            bool twoOrFour;
            int numWheels;
            do
            {
                Console.WriteLine("Would you like your vehicle to have 2 or 4 wheels?");
                var answer = Console.ReadLine();
                twoOrFour = int.TryParse(answer, out numWheels);
                twoOrFour = false;
                if (numWheels == 2 || numWheels == 4) { twoOrFour = true; }
                // if (numWhees != 2 || numWheels != 4) { twoOrFour = false; } -- kept returning false regardless of input...
            } while (twoOrFour == false);
            return numWheels == 4 ? new Car() : new Motorcycle();
        }
    }
}
