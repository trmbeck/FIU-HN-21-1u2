using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Bus : IVehicle
    {
        public void Move(string to)
        {
            Console.WriteLine("Bus is moving to " + to);
        }
    }
}
