// See https://aka.ms/new-console-template for more information

using KlassendiagrammAnwendung;

Kunde kunde1 = new ();
Artikel artikel1 = new (1) { Beschreibung = "Solaranlage (toll)", Preis = 2000 };
Artikel artikel2 = new(2) { Beschreibung = "Heizung (toll)", Preis = 1000 };
Adresse adresse = new () { Strasse = "Musterweg", Hausnummer = "1a", Ort = "Musterhausen", Plz = "12345", Land = Land.de };

Klassendiagramm.Rechnung rechnung1 = new () { Kunde = kunde1, RechnubgsId = 1, RechnungsDatum = DateTime.Now };

//kunde1.RechnungsListe = new List<Rechnung>();
kunde1.RechnungsListe.Add(rechnung1);

//Artikelposition pos1 = new Artikelposition() { Posnr = 1, Artikel = artikel1, Menge = 2 };
rechnung1.AddArtikel(artikel1, 2);
rechnung1.AddArtikel(artikel2, 1);

//artikel1.ArtikelId = 1234;
foreach (var rechnung in kunde1.RechnungsListe)
{
    Console.WriteLine("Betrag Rechnungsnummer {0}: {1:f2} Euro",rechnung.RechnubgsId, rechnung.GetBetrag());
    Console.WriteLine("Bruttobetrag Rechnungsnummer {0}: {1:f2} Euro", rechnung.RechnubgsId, rechnung.GetBetrag()*(rechnung.Mwst+1));
}

Console.WriteLine();