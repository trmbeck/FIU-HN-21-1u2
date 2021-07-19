using System;

namespace Einfuehrung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            int kapital;
            Console.WriteLine("Bitte Kapital eingeben");
            string eingabe = Console.ReadLine();
            kapital = Convert.ToInt32(eingabe);
            double zinsen = kapital * 0.03;
            Console.WriteLine("Ihre Zinsen betragen: {0:f2}",zinsen);
            Console.WriteLine($"Ihre Zinsen betragen: {zinsen}");

            //Escape-Sequenz -> Einleitung durch \
            Console.WriteLine("Hallo\rWelt\a");
            Console.WriteLine("\\\\Server01\\freigabename\\ordner");// -> \Server01reigabename
            //Verbatim-String
            Console.WriteLine(@"\\Server01\Freigabename\ordner");
            Console.ReadLine();
        }
    }
}
