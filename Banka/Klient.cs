using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;


namespace Banka
{
    public class Klient
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string PrihlasovaciJmeno { get; set; }
        public string Heslo { get; set; }

        public List<BeznyUcet> BezneUcty = new List<BeznyUcet>();
        public List<SporiciUcet> SporiciUcty = new List<SporiciUcet>();


        public Klient(string jmeno, string prijmeni, string prihlasovaciJmeno, string heslo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            PrihlasovaciJmeno = prihlasovaciJmeno;
            Heslo = heslo;
        }

        public Klient(string radekCSV)
        {
            string[] data = radekCSV.Split(';');
            Jmeno = data[0];
            Prijmeni = data[1];
            PrihlasovaciJmeno = data[2];
            Heslo = data[3];
        }
    }
}
