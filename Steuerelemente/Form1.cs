using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerelemente
{
    public partial class Form1 : Form
    {
        int a = 10;
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
            a = 11;
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
            MessageBox.Show(listBox1.SelectedItems[1].ToString() + "\r\n" + listBox1.SelectedItems.Count);
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                MessageBox.Show(listBox1.SelectedItems[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }
    }
}
