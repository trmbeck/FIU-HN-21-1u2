using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    public class Rechnung
    {
        private int rechnubgsId;
        private double mwst = 0.19;
        private DateTime rechnungsDatum;

#nullable disable
        private Kunde kunde;
#nullable enable
        
        private List<Artikelposition> artikelpositionen = new List<Artikelposition>();

        public int RechnubgsId { get => rechnubgsId; set => rechnubgsId = value; }
        public double Mwst { get => mwst; set => mwst = value; }
        public DateTime RechnungsDatum { get => rechnungsDatum; set => rechnungsDatum = value; }
        //public  List<Artikelposition> Artikelpositionen { get => artikelpositionen; set => artikelpositionen = value; }
        public Kunde Kunde { get => kunde; set => kunde = value; }

        public double GetBetrag()
        {
            double betrag = 0;
            foreach (var artikelposition in artikelpositionen)
            {
                betrag += artikelposition.Menge * artikelposition.Artikel.Preis;
            }
            return betrag;
        }

        public void AddArtikel(Artikel artikel, double menge)
        {
            artikelpositionen.Add(
                new Artikelposition()
                {
                    Artikel = artikel,
                    Menge = menge,
                    Posnr = artikelpositionen.Count + 1
                });
        }

        public bool RemoveArtikel(Artikel artikelZuEntfernen)
        {
#nullable enable
            Artikelposition? artikelposZuEntfernen = artikelpositionen.FirstOrDefault(
                (apos) => { return apos.Artikel == artikelZuEntfernen; });
#nullable disable
            if (artikelposZuEntfernen is not null)
            {
                int posnr = artikelposZuEntfernen.Posnr;
                if (posnr != artikelpositionen.Count)
                {
                    for (int i = posnr; i < artikelpositionen.Count; i++)
                    {
                        artikelpositionen[i].Posnr = i;
                    }
                }
                artikelpositionen.Remove(artikelposZuEntfernen);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Rechnung als String, wie schon so oft :-)";
        }
    }

    public interface IPrintable
    {

    }
}
