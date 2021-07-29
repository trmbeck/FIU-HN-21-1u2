using System;

namespace IPAdressen
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPAdresse ip = new IPAdresse(); //200.100.20.40
            //ip.Set_Oktett1(200);
            //ip.Set_Oktett2(100);
            //ip.Set_Oktett3(20);
            //ip.Set_Oktett4(40);

            IPAdresse ip2 = new IPAdresse(200, 100, 20, 40);
        }
    }

    class IPAdresse
    {
        private int oktett1;
        private int oktett2;
        private int oktett3;
        private int oktett4;

        //public IPAdresse(string s)
        //{
            
        //}

        public IPAdresse(int a, int b, int c, int d)
        {
            Set_Oktett1(a);
            Set_Oktett2(b);
            Set_Oktett3(c);
            Set_Oktett4(d);
        }

        public int Get_Oktett1()
        {
            return oktett1;
        }
        public int Get_Oktett2()
        {
            return oktett2;
        }
        public int Get_Oktett3()
        {
            return oktett3;
        }
        public int Get_Oktett4()
        {
            return oktett4;
        }

        public string GetIPAsString()
        {
            return $"{oktett1}.{oktett2}.{oktett3}.{oktett4}";
        }

        public void Set_Oktett1(int oktett) //127
        {
            if (oktett > 255) oktett1 = 255;
            else if (oktett < 0) oktett1 = 0;
            else
            oktett1 = oktett;
        }
        public void Set_Oktett2(int oktett) //127
        {
            if (oktett > 255) oktett2 = 255;
            else if (oktett < 0) oktett2 = 0;
            else
                oktett2 = oktett;
        }
        public void Set_Oktett3(int oktett) //127
        {
            if (oktett > 255) oktett3 = 255;
            else if (oktett < 0) oktett3 = 0;
            else
                oktett3 = oktett;
        }
        public void Set_Oktett4(int oktett) //127
        {
            if (oktett > 255) oktett4 = 255;
            else if (oktett < 0) oktett4 = 0;
            else
                oktett4 = oktett;
        }
    }
}
