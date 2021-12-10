using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beobachter
{
    // Beobachter konkretes Subjekt
    internal class TemperaturSensor
    {
        List<ISensorBeobachter> registrierteTempBeobachter = new List<ISensorBeobachter>();

        private float temperatur;
        public float Temperatur
        {
            get => temperatur;
            set
            {
                if (temperatur != value)
                {
                    temperatur = value;
                    Benachrichtigen();
                }
            }
        }

        public void Registrieren(ISensorBeobachter b)
        {
            ArgumentNullException.ThrowIfNull(b);
            registrierteTempBeobachter.Add(b);
        }

        public void Entfernen(ISensorBeobachter b)
        {
            _ = b ?? throw new ArgumentNullException(nameof(b));
            registrierteTempBeobachter.Remove(b);
        }

        public void Benachrichtigen()
        {
            foreach (ISensorBeobachter beobachter in registrierteTempBeobachter)
            {
                beobachter.Aktualisieren(this.Temperatur);
            }
        }
    }
}
