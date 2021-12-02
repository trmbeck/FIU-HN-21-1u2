using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    public class Artikel
    {
        private readonly int artikelId;
        private double preis;
        private string beschreibung = String.Empty;

        public int ArtikelId { get => artikelId; }
        public double Preis { get => preis; set => preis = value; }
        public string Beschreibung { get => beschreibung; set => beschreibung = value; }

        public Artikel(int ArtikelId)
        {
            this.artikelId = ArtikelId;
        }
    }
}
