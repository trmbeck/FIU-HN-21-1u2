using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    public class Adresse
    {
        private string strasse = String.Empty;
        private string hausnummer = String.Empty;
        private string plz = String.Empty;
        private string ort = String.Empty;
        private Land land;

        public Adresse()
        {
            
        }

        public string Strasse { get => strasse; set => strasse = value; }
        public string Hausnummer { get => hausnummer; set => hausnummer = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public Land Land { get => land; set => land = value; }
    }
}
