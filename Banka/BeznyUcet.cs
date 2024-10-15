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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">Zadávajte buďto jméno klienta nebo radekCSV</param>
        public BeznyUcet(string text) {
            if (text.Contains(";"))
            {
                Klient = text.Split(';')[0];
                TypUctu = text.Split(';')[1];
                CisloUctu = Convert.ToInt32(text.Split(';')[2]);
                Castka = Convert.ToInt32(text.Split(';')[3]);
            }
            else
            { 
                Klient = text;
                TypUctu = "Bezny Ucet";
            }
        }
    }
}

