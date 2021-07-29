using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heizungsanlage
{
    class Heizung
    {
        private int stufe = 3; // 0-5
        public string name;
        public double istTemperatur;
        public double wasserstand;

        public void StufeErhoehen()
        {
            if (stufe < 5)
            { 
                stufe++;
            }
        }

        public void StufeVerringern()
        {
            if(stufe > 0)
            stufe--;
        }

        public void Ausschalten()
        {
            stufe = 0;
        }

        public int GetStufe()
        {
            return stufe;
        }
    }
}
