using System;

namespace Passwort
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            int zaehler = 1;
            bool P = false, R = false, O = false, G = false;
            int anzahl = 1;

            do
            {
                do
                {
                    Console.WriteLine($"bitte {zaehler}. Zeichen eingeben:");
                    eingabe = Console.ReadLine();

                    if (eingabe.ToUpper() == "P") P = true;
                    if (eingabe.ToUpper() == "R") R = true;
                    if (eingabe.ToUpper() == "O") O = true;
                    if (eingabe.ToUpper() == "G") G = true;

                    #region Lösung mit switch
                    switch (eingabe.ToUpper())
                    {
                        case "P":
                            P = true;
                            break;
                        case "R":
                            R = true;
                            break;
                        case "O":
                            O = true;
                            break;
                        case "G":
                            G = true;
                            break;
                    }
                    #endregion

                    zaehler++;
                } while (zaehler <= 4);
                
                zaehler = 1;
                if (P && R && O && G)
                {
                    //passwort korrekt!!!
                    Console.WriteLine("korrekt");
                    break;
                }
                else
                {
                    Console.WriteLine("falsch");
                }
                anzahl++;
            } while (anzahl <= 3);
        }
    }
}
