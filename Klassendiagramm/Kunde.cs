using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    public class Person
    {
        protected static int naechsteKundennummer = 1;
        protected readonly int kundenId; // --> Valuetype
        protected string nachname = String.Empty;
        protected string vorname = "";
        protected Datum geburtsdatum = new Datum(); //struct -> Valuetype
        protected bool vip;
        protected bool buisinesskunde;

//#nullable disable
        protected Adresse rechnungsadresse = new Adresse();
        protected Adresse lieferadresse = new Adresse();
//#nullable enable

        protected List<Rechnung> rechnungsListe = new List<Rechnung>();

        public int KundenId { get => kundenId; init => kundenId = value; } // init -> nur bei Initialisierung
        public string Vorname { get => vorname; set => vorname = value; }
        public Datum Geburtsdatum { get => geburtsdatum; set => geburtsdatum = value; }
        public bool Vip { get => vip; set => vip = value; }
        public bool Buisinesskunde { get => buisinesskunde; set => buisinesskunde = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        internal Adresse Rechnungsadresse { get => rechnungsadresse; set => rechnungsadresse = value; }
        internal Adresse Lieferadresse { get => lieferadresse; set => lieferadresse = value; }
        internal List<Rechnung> RechnungsListe { get => rechnungsListe; set => rechnungsListe = value; }

        public Person()
        {
            KundenId = naechsteKundennummer++;
            Debug.WriteLine("id: " + KundenId);
            Debug.WriteLine("nächste ID: " + naechsteKundennummer);
        }
    }

    public class Kunde : Person, IEnumerable, IComparable
    {
        public Kunde() : base()
        {

        }
        public int CompareTo(object? obj)
        { 
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
