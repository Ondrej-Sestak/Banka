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
        public string NazevUctu { get; set; } = "Běžný účet";
        public int CisloUctu { get; set; }
        public decimal Castka { get; set; } = 0;
        public string Klient { get; set; }
        public string TypUctu { get; set; }

        public BeznyUcet(string nazevUctu, string klient) {
            TypUctu = "Běžný účet";
            NazevUctu = nazevUctu;
            Klient = klient;
            CisloUctu = VytvoreniCislaUctu();
            if (CisloUctu == -1)
            {
                throw new ArgumentException("Došli nám čísla účtů, kontaktujte prosím naší banku.");
            }
        }

        public BeznyUcet(string radekCSV)
        {
                NazevUctu = radekCSV.Split(';')[0];
                Klient = radekCSV.Split(';')[1];
                TypUctu = radekCSV.Split(';')[2];
                CisloUctu = Convert.ToInt32(radekCSV.Split(';')[3]);
                Castka = Convert.ToInt32(radekCSV.Split(';')[4]);
        }

        public BeznyUcet(string nazevUctu, string klient, string typUctu, string cisloUctu, string castka){
            NazevUctu = nazevUctu;
            Klient = klient;
            TypUctu= typUctu;
            CisloUctu= Convert.ToInt32(cisloUctu);
            Castka = Convert.ToInt32(castka);
        }

        public string ToCSV()
        {
            return NazevUctu + ";" + Klient + ";" + TypUctu + ";" + CisloUctu + ";" + Castka;
        }

        public override string ToString()
        {
            return NazevUctu + " " + Castka + " Kč";
        }

        public string ZobrazUcet()
        {
            return Klient + ": " + NazevUctu;
        }

        public decimal PosliPenize(decimal castka)
        {
            return Math.Round(Castka - castka,2);
        }

        public decimal PrijmiPenize(decimal castka)
        {
            return Math.Round(Castka + castka, 2);
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

