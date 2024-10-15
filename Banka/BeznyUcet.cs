using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /// <param name="text">Zadávajte buďto jméno klienta nebo řádek CSV</param>
        public BeznyUcet(string text) {
            if (text.Contains(";"))
            {
                Klient = text.Split(';')[0];
                TypUctu = text.Split(';')[1];
                CisloUctu = Convert.ToInt32(text.Split(';')[2]);
                Castka = Convert.ToInt32(text.Split(';')[3]);
            }
            else{ 
                TypUctu = "Běžný účet";
                Klient = text;
                CisloUctu = VytvoreniCislaUctu();
                if (CisloUctu == -1)
                {
                    throw new ArgumentException("Došli nám čísla účtů, kontaktujte prosím naší banku.");
                }
            }
        }

        public BeznyUcet(string klient, string typUctu, string cisloUctu, string castka) {
            Klient = klient;
            TypUctu= typUctu;
            CisloUctu= Convert.ToInt32(cisloUctu);
            Castka = Convert.ToInt32(castka);
        }

        public string ToCSV()
        {
            return Klient + ";" + TypUctu + ";" + CisloUctu + ";" + Castka;
        }

        public override string ToString()
        {
            return Klient + " " + Castka + " Kč";
        }

        public int VytvoreniCislaUctu()
        {
            Random random = new Random();
            int cislo = 0;
            bool JednoCisloSeShoduje = false;
            do
            {
                cislo = random.Next(10000, 99999);

                foreach (BeznyUcet beznyUcet in Globalni.seznamBeznychUctu)
                {
                    if (beznyUcet.CisloUctu == cislo)
                    {
                        JednoCisloSeShoduje = true;
                    }
                }

                foreach (SporiciUcet sporiciUcet in Globalni.seznamSporicichUctu)
                {
                    if (sporiciUcet.CisloUctu == cislo)
                    {
                        JednoCisloSeShoduje = true;
                    }
                }

            } while (JednoCisloSeShoduje);

            if (!JednoCisloSeShoduje)
                return cislo;
            else return -1;
        }

        
    }
}

