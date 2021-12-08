using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public enum VehicleTypes
    {
        car,
        bus
    }
    internal class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleTypes type)
        {
            switch (type)
            {
                case VehicleTypes.car:
                    return new Car();
                case VehicleTypes.bus:
                    return new Bus();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
