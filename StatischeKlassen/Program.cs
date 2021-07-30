using System;

namespace StatischeKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathe m = new Mathe();
            Mathe.Summe(9, 3, 6, 2, 4.3, 6.7);
            Console.WriteLine(Mathe.PI);//m.PI = 1.3;
            //Mathe n = new Mathe(); 
            Console.WriteLine(Mathe.PI);
            Mathe.Summe(2, 4, 6, 8, 1, 3);
            m.wert = -30;
            Console.WriteLine(m.Betrag());
            Console.WriteLine(Mathe.Betrag(-254354));
        }
    }
}
