Disziplin d = new Disziplin();
Sportler s1 = new();
Sportler s2 = new Sportler();
int anzahlErgebnisse = 6;
Sportler[] sportlers = new Sportler[] { s1, s2 };
double[,] ergebnisse = new double[sportlers.Length,anzahlErgebnisse];

ergebnisse[0,0] = 10;
ergebnisse[1,0] = 20;

class Disziplin
{
    string name;
    Wettkampf[] wettkämpfe;
}

class Wettkampf
{
    string name;
    double[,] ergebnisse;
    Sportler[] sportler;
    Disziplin disziplin;

    public void SetSportler(Sportler[] s)
    {
        sportler = s;
    }

    public void SetErgebnisse(double[,] e)
    {
        ergebnisse = e;
    }
}

class Sportler
{
    string name;
    Wettkampf[] wettkämpfe;
}