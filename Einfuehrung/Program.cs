using System;

namespace Einfuehrung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            int kapital = 0;
            bool zahlKorrekt = false;
            bool nochmal = true;

            bool wiederholen = false;
            string eingabe;

            do
            {
                Console.Clear();
                Console.WriteLine("a) Kapital berechnen");
                Console.WriteLine("b) Finanzierung berechnen");
                Console.WriteLine("c) Aktiendividende berechnen");
                Console.WriteLine("d) Beenden");

                Console.Write("Bitte wählen: ");
                eingabe = Console.ReadLine();

                //if (eingabe == "1") {/*Kapital berechnen*/}
                //if (eingabe == "2") {/*Finanzierung berechnen*/}
                //if (eingabe == "3") {/*Aktiendividende berechnen*/}
                //if (eingabe == "4") {/*Beenden*/}


                #region mehrseitige Auswahl
                if (eingabe == "1")
                {
                    //Kapital berechnen
                }
                else
                {
                    if (eingabe == "2")
                    {
                        //Finanzierung berechnen
                    }
                    else
                    {
                        if (eingabe == "3")
                        {
                            //Aktiendividende berechnen
                        }
                        else
                        {
                            if (eingabe == "4")
                            {
                                //Beenden
                            }
                            else
                            {
                                // Falsche Eingabe
                            }
                        }
                    }
                }
                #endregion


                wiederholen = false;
                //Fallauswahl
                switch (eingabe)
                {
                    case "A":
                    case "a":
                        // Kapitalberechnen
                        Console.WriteLine("Das Kapital wurde berechnet");
                        break;
                    case "b":
                        Console.WriteLine("Die Finanzierung wrude berechnet");
                        break;
                    case "c":
                        Console.WriteLine("Aktiendividende wurde berechnet");
                        break;
                    case "d":
                        Console.WriteLine("Beenden");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Falscheingabe");
                        wiederholen = true;
                        break;
                }
            }
            while (wiederholen);

            Console.ReadLine();

            while (nochmal)
            {
                //Console.Clear();
                do
                {
                    Console.WriteLine("Bitte Kapital eingeben");
                    eingabe = Console.ReadLine();
                    try
                    {
                        kapital = Convert.ToInt32(eingabe);
                        zahlKorrekt = true;
                    }
                    catch
                    {
                        Console.WriteLine("Falsches Format:");
                    }
                } while (!zahlKorrekt);
                zahlKorrekt = false;

                double zinsen;
                if (kapital > 10000)
                {
                    zinsen = kapital * 0.04;
                }
                else
                {
                    zinsen = kapital * 0.03;
                }


                Console.WriteLine("Ihre Zinsen betragen: {0:f2}", zinsen);
                Console.WriteLine($"Ihre Zinsen betragen: {zinsen}");

                goto EscapeSequenzFertig; //goto ist böse!!!
                                          //Escape-Sequenz -> Einleitung durch \
                Console.WriteLine("Hallo\rWelt\a");
                Console.WriteLine("\\\\Server01\\freigabename\\ordner");// -> \Server01reigabename
                                                                        //Verbatim-String
                Console.WriteLine(@"\\Server01\Freigabename\ordner");
                Console.ReadLine();
            //Fertig
            //weitere Version
            EscapeSequenzFertig:
                Console.WriteLine("Nochmal (J/N)?");
                if (Console.ReadLine().ToUpper() != "J") nochmal = false;

            }





        }
    }
}
