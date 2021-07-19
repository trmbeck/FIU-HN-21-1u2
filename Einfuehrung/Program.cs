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


            while (nochmal)
            {
                Console.Clear(); 
                do
                {
                    Console.WriteLine("Bitte Kapital eingeben");
                    string eingabe = Console.ReadLine();
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

                goto EscapeSequenzFertig;
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
