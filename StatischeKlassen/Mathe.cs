using System;
using System.Collections.Generic;
using System.Text;

namespace StatischeKlassen
{
    class Mathe
    {
        public double wert; //Objektvariable
        public const double PI = 3.14; //Klassenvariable
        public static readonly double pi = 3.14; // nicht mehr änderbar (readonly)
        public static double Summe(params double[] summanden) //Klassenmethode
        {
            double result = 0;
            foreach (var sumand in summanden)
            {
                result += sumand;
            }
            return result;
        }

        public double Betrag() //Objektmethode
        {
            if (wert < 0) return wert * -1;
            else return wert;
        }
        public static double Betrag(double betrag) //Klassenmethode
        {
            if (betrag < 0) return betrag * -1;
            else return betrag;
        }
    }
}
