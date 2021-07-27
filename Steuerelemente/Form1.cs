using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                progressBar1.Value += 10;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemsInListbox = "";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                itemsInListbox += listBox1.Items[i].ToString() + "\r\n";
            }

            MessageBox.Show(itemsInListbox);


            listBox1.Items[0] = "C++";
            //Form2 f = new Form2();
            //f.Show();

            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
