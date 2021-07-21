using System;

namespace Durchschnitt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Schreiben Sie ein Programm, welches fünf Zahlen abfrägt und 
                danach den Durchschnitt dieser Zahlen berechnet und ausgibt.

                Erweitern Sie das Programm so, dass die Abfrage der Zahlen vorzeitig 
                beenden werden kann, wenn der Buchstabe "A" eingegeben wird. 
                Falls die fünfte Zahl eingegeben wurde beenden Sie ebenfalls die Abfrage. 
                Berechnen Sie aus den eingegebenen Zahlen den Durchschnitt und 
                geben Sie ihn aus. 
             */
            int summe = 0;
            int i;
            for (i = 0; i < 5; i = i + 1)
            {
                string eingabe = Console.ReadLine();
                if (eingabe == "a")
                {
                    //abbrechen
                    break;
                }
                else
                {
                    summe = summe + int.Parse(eingabe);
                }
            }
            
            //weiter nach der Schleife
            Console.WriteLine("Durchschnitt: " + (summe/(double)i));


        }
    }
}
