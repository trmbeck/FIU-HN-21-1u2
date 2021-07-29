using System;

namespace Referenz_Heap_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t;                  // Variable t vom Typ Test
            t = new Test();          // Erzeugen einer Instanz (Konstruktoraufruf)
            int wert = 10;           // im Stack gespeichert
            t.manipulieren(ref wert);// Call by Reference
            Console.WriteLine(wert); // Call by Value

            Test objekt1 = new Test();
            Test objekt2 = new Test();

            Console.WriteLine("-----------------------------");


            Console.WriteLine(objekt1.a); //10
            Console.WriteLine(objekt2.a); //10

            Console.WriteLine("-----------------------------");
            objekt1.a = 11;                 
            objekt2.a = 20;
            Console.WriteLine(objekt1.a); //11
            Console.WriteLine(objekt2.a); //20
            objekt1 = objekt2;
            Console.WriteLine("-----------------------------");

            Console.WriteLine(objekt1.a); //20
            Console.WriteLine(objekt2.a); //20
            objekt1.a++;
            Console.WriteLine("-----------------------------");
            Console.WriteLine(objekt1.a); //21
            Console.WriteLine(objekt2.a); //21

        }
    }
    class Test
    {
        public int a = 10;
        public void manipulieren(ref int w)
        {
            w++;
            Console.WriteLine($"Wert: {w}");
        }
    }
}
