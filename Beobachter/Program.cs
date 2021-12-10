// See https://aka.ms/new-console-template for more information
using Beobachter;

Console.WriteLine("Beobchter / Observer");

TemperaturSensor sensor = new TemperaturSensor();
ISensorBeobachter beobachter1 = new TempAnzeige();
ISensorBeobachter beobachter2 = new TempAlarm();

sensor.Registrieren(beobachter1);
sensor.Registrieren(beobachter2);

sensor.Temperatur = 13.6F;
sensor.Temperatur = 20.4F;
sensor.Temperatur = 2.4F;