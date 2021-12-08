using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void Move(string to)
        {
            Console.WriteLine("Car is moving to " + to);
        }
    }
}
