using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beobachter
{
    // Beobachter konkreter Beobachter
    internal class TempAlarm : ISensorBeobachter
    {
        public void Aktualisieren(float wert)
        {
            if (wert < 3)
                Console.WriteLine($"Alarm: Frostgefahr!!!");
        }
    }
}
