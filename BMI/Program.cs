using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entwerfen(PAP und Struktogramm) und implementieren(C# Code) Sie ein Programm, das den Body-Mass-Index errechnet. Nach Eingabe von Körpergröße l (Eingabe in cm, dann Umrechnung in m) und Gewicht m (in kg) wird der Index wie folgt berechnet:

            //BMI = m / l²


            //Ist der Wert unter 18,5 wird von Untergewicht gesprochen, bei einem Wert ab 25 von Übergewicht. Normalgewicht gilt bei allen anderen Werten.

            //Eingabe: Körpergröße in cm, Gewicht in kg

            //Ausgabe: "Untergewicht", "Normalgewicht", "Übergewicht"

            double l;
            double m;
            double bmi;

            Console.Write("Bitte Körpergröße in cm angeben: ");
            string eingabe = Console.ReadLine();
            l = Convert.ToDouble(eingabe);

            Console.Write("Bitte Gewicht in kg angeben: ");
            eingabe = Console.ReadLine();
            m = Convert.ToDouble(eingabe);

            //l = l / 100; // von cm nach m

            bmi = m / ((l / 100) * (l / 100));

            if (bmi < 18.5)
            {
                Console.WriteLine("Untergewicht");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("Übergewicht");
            }
            else
            {
                Console.WriteLine("Normalgewicht");
            }
            Console.WriteLine("BMI: " + bmi);

            Console.WriteLine("Bitte Taste drücken ...");
            Console.ReadKey();
        }
    }
}
