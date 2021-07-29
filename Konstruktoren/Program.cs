using System;

namespace Konstruktoren
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(); // Konstruktorbezeichner ist der Klassenname
            Test2 t2 = new Test2(10);
            Test2 u2 = new Test2();

            Fzg f1 = new Fzg(20,200);

        }
    }

    class Test
    {
        public Test()
        {
            Console.WriteLine("Konstruktoraufruf");
        }
    }
    class Test2
    {
        public int feld1;
        public Test2(int a)
        {
            Console.WriteLine(a);
            feld1 = a;
        }

        public Test2()
        {
            feld1 = 1111;
        }
    }

    class Fzg
    {
        public int Leistung;
        public double maxGeschw;
        public int Raeder;
        public Fzg(int l) : this(l, 100)
        {
            //Leistung = l;
            //maxGeschw = 100;
        }

        public Fzg(int leistung, double maxGeschw) : this (leistung, maxGeschw, 4)
        {

        }

        public Fzg(int leistung, double maxGeschw, int AnzahlRaeder)
        {
            Leistung = leistung;
            this.maxGeschw = maxGeschw;
            Raeder = AnzahlRaeder;
        }
    }
}
