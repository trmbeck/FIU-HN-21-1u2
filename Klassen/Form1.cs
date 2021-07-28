using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 3;
            y = 1;

            int[] p = new int[2];
            p[0] = 3;
            p[1] = 1;

            Punkt p1;
            p1 = new Punkt(); //Erzeugen eines Punktobjektes (instanziieren)
            p1.y = 1;
            p1.x = 3;

            txbOutput.Text = $"x: {p1.x} | y: {p1.y}";
        }
    }
    class Punkt 
    {
        /*Felder, fields*/
        public int x = 0; 
        public int y = 0; 
    }
}
