using System;
using System.Windows.Forms;


namespace MeinErstesWinFormsFenster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jetzt kommt ein Formular (Fenster):");

            Form ersteForm = new Form();

            ersteForm.Width = 800;
            ersteForm.Text = "Mein tolles Fenster";

            Application.Run(ersteForm);
        }
    }
}
