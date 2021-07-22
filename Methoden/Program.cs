using System;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string eingabe;
            //Menü
            do
            {
                Unterprogramm();
                eingabe = Console.ReadLine(); //Eingabe eines Menüpunktes
                Console.Clear();
                switch (eingabe)
                {
                    case "1":
                        PrimzahlenBis50();
                        break;
                    case "2":
                        double nummer = DoubleZahlEingeben();
                        double invNummer = Invertieren(nummer);
                        break;
                    case "3":
                        double[] nummern = ZahlenEingeben(2);
                        double s = Addieren(nummern[0], nummern[1]);
                        Console.WriteLine(s);
                        break;
                    case "4":
                        Subtrahieren();
                        break;
                    case "6":
                        ZahlenEingeben(10);
                        break;
                }

                Console.ReadLine();
            } while (eingabe != "5");




        }


        static double[] ZahlenEingeben(int anzahl)
        {
            double[] zahlen = new double[anzahl];
            for (int i = 0; i < anzahl; i++)
            {
                Console.Write("Zahl {0} eingeben: ", i + 1);
                zahlen[i] = double.Parse(Console.ReadLine());
            }
            return zahlen;
        }

        static double Addieren(double z1, double z2)
        {
            double summe = z1 + z2;
            return summe;
        }

        static double DoubleZahlEingeben()
        {
            Console.WriteLine("Zahl eingeben: ");
            double zahl = double.Parse(Console.ReadLine());
            return zahl;
        }

        static void Subtrahieren()
        {
            Console.WriteLine("Zahl 1 eingeben: ");
            double zahl1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zahl 2 eingeben: ");
            double zahl2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Differenz: " + (zahl1 - zahl2));
        }

        static double Invertieren(double zuInvertierendeZahl)
        {
            double InvertierteZahl = zuInvertierendeZahl * -1;
            Console.WriteLine("Invertiert: " + InvertierteZahl);
            return InvertierteZahl;
        }

        static void PrimzahlenBis50()
        {
            Console.WriteLine("Primzahlen bis 50:");
            Console.WriteLine("2\t3\t5\t7\t11\t13\t17\t19\t23\t29\t31\t37\t41\t47");
        }


        static void Unterprogramm()
        {
            Console.Clear();
            Console.WriteLine("1. Primzahlen bis 50");
            Console.WriteLine("2. Invertieren");
            Console.WriteLine("3. Addieren");
            Console.WriteLine("4. Subtrahieren");
            Console.WriteLine("5. Beenden");
            Console.WriteLine("6. Untermenue");
            Console.WriteLine("Ihre Wahl: ");
        }

        static void Untermenue()
        {
            Console.WriteLine("1. bla");
            Console.WriteLine("2. fasel");
            Console.WriteLine("3. zurück");
        }

    }
}
