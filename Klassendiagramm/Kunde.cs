using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    public class Kunde
    {
        private static int naechsteKundennummer = 1;

        private readonly int kundenId;
        private string nachname = String.Empty;
        private string vorname = "";
        private DateTime geburtsdatum;
        private bool vip;
        private bool buisinesskunde;

#nullable disable
        private Adresse rechnungsadresse;
        private Adresse lieferadresse;
#nullable enable

        private List<Rechnung> rechnungsListe = new List<Rechnung>();

        public int KundenId { get => kundenId; init => kundenId = value; } // init -> nur bei Initialisierung
        public string Vorname { get => vorname; set => vorname = value; }
        public DateTime Geburtsdatum { get => geburtsdatum; set => geburtsdatum = value; }
        public bool Vip { get => vip; set => vip = value; }
        public bool Buisinesskunde { get => buisinesskunde; set => buisinesskunde = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        internal Adresse Rechnungsadresse { get => rechnungsadresse; set => rechnungsadresse = value; }
        internal Adresse Lieferadresse { get => lieferadresse; set => lieferadresse = value; }
        internal List<Rechnung> RechnungsListe { get => rechnungsListe; set => rechnungsListe = value; }

        public Kunde()
        {
            KundenId = naechsteKundennummer++;
            Debug.WriteLine("id: " + KundenId);
            Debug.WriteLine("nächste ID: " + naechsteKundennummer);
        }
    }
}
