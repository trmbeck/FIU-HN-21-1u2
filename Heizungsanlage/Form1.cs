using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heizungsanlage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Heizung wohnzimmerheizung = new Heizung();
            wohnzimmerheizung.name = "Wohnzimmer";
            wohnzimmerheizung.StufeErhoehen();
            wohnzimmerheizung.StufeErhoehen();
            wohnzimmerheizung.StufeErhoehen();
            wohnzimmerheizung.StufeErhoehen();
            wohnzimmerheizung.StufeErhoehen();
            wohnzimmerheizung.StufeVerringern();
            wohnzimmerheizung.Ausschalten();



            txbOutput.Text = wohnzimmerheizung.GetStufe().ToString();
        }
    }

}
