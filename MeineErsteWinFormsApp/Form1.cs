using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeineErsteWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Eingabe = txbEingabe.Text;
            MessageBox.Show("Hallo " + Eingabe);
            txbEingabe.Text = "";
        }

        private void btnCopyPaste_Click(object sender, EventArgs e)
        {
            if (txbEingabe.Text != "")
            {
                if (txbAusgabe.Text == "")
                    txbAusgabe.Text = txbEingabe.Text;
                else
                    txbAusgabe2.Text = txbEingabe.Text;
            }
            txbEingabe.Text = "";
        }
    }
}
