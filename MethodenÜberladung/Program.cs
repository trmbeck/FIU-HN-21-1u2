using System;

namespace MethodenÜberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ein bisschen Mathe");
            Mathe m = new Mathe();
            double result = m.Addition(11.0, 23.2,22.5);
            Console.WriteLine(result);
            result = m.Addition(11.0, 23.2);
            Console.WriteLine(m.Addition(1,1,1,1));
            Console.WriteLine(m.Addition(10,10,10,10,100));

            result = m.Addition(3, 2, 5, 4, 2, 1, 2, 3, 4, 5, 6);
            Console.WriteLine(result);
        }
    }
    class Mathe
    {
        public double Addition(double zahl1, double zahl2, double zahl3)
        {
            double ergebnis = zahl1 + zahl2 +zahl3;
            return ergebnis;
        }

        public double Addition(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }

        public double Addition(double zahl1, double zahl2, double zahl3, double zahl4,double zahl5 = 10)
        {
            return zahl1 + zahl2 + zahl3 + zahl4 + zahl5;
        }

        public double Addition(params double[] zahlen)
        {
            double ergebnis = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                ergebnis += zahlen[i];
            }
            return ergebnis;
        }

        public void test(int i, double d)
        {

        }

        public void test(double d, int i)
        {

        }

        //public int test(double d, int i)
        //{
        //    return 1;
        //}
    }
}
