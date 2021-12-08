using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal sealed class Person
    {
        private static int counter = 0;
        private static Person instance = null;
        private static readonly object obj = new object();
        private Person()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter);
        }

        public static Person GetInstance()
        {
            lock(obj)
            {
                if (instance is null) instance = new Person();
            }
            return instance;
        }
        public void PrintDetails(string message)
        { 
            Console.WriteLine(message); 
        }
        //internal class Employee : Person
        //{
        //    public Employee() : base()
        //    {

        //    }
        //}
    }

}
