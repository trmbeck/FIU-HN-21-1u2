using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendiagramm
{
    public struct Datum
    {
        int tag = 1, monat = 1, jahr = 1;
        public Datum(int y, int m, int d)
        {
            tag = d;
            monat = m;
            jahr = y;
        }

        public override string ToString()
        {
            return String.Format($"{tag}.{monat}.{jahr}");
        }
    }
}
