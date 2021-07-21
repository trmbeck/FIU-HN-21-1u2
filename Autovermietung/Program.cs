using System;

namespace Autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Entwerfen (PAP oder Struktogramm) und implementieren (C# Code) Sie ein Rechnungsprogramm für einen Automvermieter. Wenn ein Kunde den Normaltarif (68€) auswählt, sind 200 km Fahrtstrecke inkludiert. Erst wenn der Kunde mehr als 200 km fährt, muss er 65 Cent pro weiteren Kilometer zahlen. Die Preise sind exkl. Mehrwertsteuer.

                Eingabe: gefahrene Kilometer

                Ausgabe: Rechnungsbetrag inkl. MwSt., MwSt. als Betrag
             */

            double mwstSatz = 0.19;
            double zuschlag = 0.65;
            double normaltarif = 68;
            double kilometerFrei = 200;
            double nettobetrag;
            double kilometer;
            double mwstBetrag;

            Console.Write("gefahrene Kilometer: ");
            string eingabe = Console.ReadLine();
            kilometer = Convert.ToDouble(eingabe);

            if (kilometer > 200)
            {
                //Aufschlag
                nettobetrag = normaltarif + (kilometer - kilometerFrei) * zuschlag;
            }
            else
            {
                //Normaltarif
                nettobetrag = normaltarif;
            }

            mwstBetrag = nettobetrag * mwstSatz;


            Console.WriteLine("Rechnungsbetrag: {0:f2}", nettobetrag + mwstBetrag);
            Console.WriteLine("enthaltene MwSt: {0:f2}", mwstBetrag);

            Console.WriteLine("Bitte Taste drücken ...");
            Console.ReadKey();

        }
    }
}
