using System;

namespace CSharpDoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Doom");
            Spieler hans = new Spieler();
            
            hans.Erfahrung = 0;
            hans.Ausruestung = new string[10];
            hans.Lebenspunkte = 100.0;
            hans.Ruestung = 50;

            Waffe kettensaege = new Waffe();
            kettensaege.Name = "Kettensaege"; // :-D
            kettensaege.Ladung = 100;
            kettensaege.Schaden = 2;
            kettensaege.Abnutzung = 0.1;


            hans.Angriffsgeraet = kettensaege;
            hans.Angriffsgeraet.Ladung -= 10;
            
            bool eventloop = true;
            do
            {
                //Tastatur abfragen
                // wenn linke pfeiltaste gedrückt
                hans.Bewegen("links");
                // wenn rechte pfeiltaste gedrückt
                hans.Bewegen("rechts");
            } while (eventloop);

        }
    }

    /*
     
    +---------------------+
    |       Spieler       |
    +---------------------|
    |  

     */

    class Spieler
    {
        public double Lebenspunkte;
        public string[] Ausruestung;
        public int Erfahrung;
        public int Ruestung;
        public Waffe Angriffsgeraet;
        public Punkt Position = new Punkt() { x = 0, y = 0};

        public void Bewegen(string richtung)
        {
            switch (richtung)
            {
                case "rechts":
                    Position.x++;
                    break;
                case "links":
                    Position.x--;
                    break;
                case "vor":
                    Position.y++;
                    break;
                case "zurück":
                    Position.y--;
                    break;
            }
        }

    }

    class Punkt
    {
        public double x;
        public double y;
    }
    class Waffe
    {
        public string Name;
        public int Ladung;
        public double Schaden;
        public double Abnutzung;
    }
}
