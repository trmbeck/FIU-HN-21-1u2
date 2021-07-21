using System;

namespace Energieverbrauch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Teil 1:
             Erstellen Sie eine neue Konsolenanwendung namens "Energieverbrauch".
             Definieren Sie die Variablen, um den Energieverbrauch eines elektrischen Geräts für ein Jahr zu berechnen.
             Berechnung: Verbrauch = Elektrische Leistung x Stunden je Tag x Tage pro Jahr

             Teil 2:
             Implementieren Sie folgende Ein- und Ausgaben
             Eingaben: elektrische Leistung, Stunden je Tag, Tage pro Jahr
             Ausgaben: elektrische Leistung 
             */

            //Deklaration und Initialisierung von Variablen
            int leistung, stunden, tage = 300; // die Werte nennt man Literale

            //Eingabe
            Console.Write("Leistung: ");
            string eingabe = Console.ReadLine();
            leistung = Convert.ToInt32(eingabe);

            Console.Write("Stunden: ");
            eingabe = Console.ReadLine();
            stunden = Convert.ToInt32(eingabe);

            Console.Write("Tage: ");
            eingabe = Console.ReadLine();
            tage = Convert.ToInt32(eingabe);

            int verbrauch;

            //Verarbeitung
            verbrauch = leistung * stunden * tage;

            //Ausgabe
            Console.WriteLine("Verbrauch: " + verbrauch + "Wh");

            //Obligatorisches Anhalten
            Console.WriteLine("bitte Taste drücken zum beenden ...");
            Console.ReadKey();
            //Console.ReadLine();
        }
    }
}
