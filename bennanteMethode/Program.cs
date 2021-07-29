using System;

namespace bennanteMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = 100;
            Console.WriteLine("Hello World!");
            Test t = new Test();
            t.Methode1(100, 190);
            t.Methode1(groesse: 190, gewicht: g);
        }
    }

    class Test
    {
        public void Methode1(double gewicht, double groesse)
        {

        }
    }
}
