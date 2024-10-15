using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class BeznyUcet
    {
        public int CisloUctu { get; set; }
        public int Castka { get; set; } = 0;

        public string Klient { get; set; }
        public string TypUctu { get; set; }

        public BeznyUcet(string radekCSV)
        {
            Klient = radekCSV.Split(';')[0];
            TypUctu = radekCSV.Split(';')[1];
            CisloUctu = Convert.ToInt32(radekCSV.Split(';')[2]);
            Castka = Convert.ToInt32(radekCSV.Split(';')[3]);
        }
    }
}

