// See https://aka.ms/new-console-template for more information
using FactoryPattern;

Console.WriteLine("Hello, Factory Pattern!");

var car = VehicleFactory.CreateVehicle(VehicleTypes.car);
var bus = VehicleFactory.CreateVehicle(VehicleTypes.bus);

car.Move("somewhere");
bus.Move("anywhere");
