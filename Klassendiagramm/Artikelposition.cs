using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    internal class Artikelposition
    {
        private int posnr;
#nullable disable
        private Artikel artikel;
#nullable enable

        private double menge;

        public double Menge
        {
            get { return menge; }
            set { menge = value; }
        }
        public Artikel Artikel
        {
            get { return artikel; }
            set { artikel = value; }
        }
        public int Posnr
        {
            get { return posnr; }
            set { posnr = value; }
        }

    }
}
