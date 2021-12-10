using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beobachter
{
    // Beobachter konkreter Beobachter
    internal class TempAnzeige : ISensorBeobachter
    {
        public void Aktualisieren(float wert)
        {
            Console.WriteLine($"Anzeige Wert: {wert} °C");
        }
    }
}
