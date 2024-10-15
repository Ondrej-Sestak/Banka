using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class FormPrihlaseni : Form
    {
        public FormPrihlaseni()
        {
            InitializeComponent();
        }

        private void btVytvoritUcet_Click(object sender, EventArgs e)
        {
            
        }

        private void btPrihlasit_Click(object sender, EventArgs e)
        {
            if (tbPrihlasovaciJmeno.Text != string.Empty && tbHeslo.Text != string.Empty)
            {
                bool UcetBylNajit = false;
                foreach (Klient klient in Globalni.seznamKlientu)
                {
                    if (klient.Jmeno == tbPrihlasovaciJmeno.Text)
                    {
                        FormSpravaUctu formSpravaUctu = new FormSpravaUctu(klient);
                        UcetBylNajit = true;
                        break;
                    }
                }
                if (!UcetBylNajit)
                    MessageBox.Show("Zadané údaje nejsou zprávné, zkuste to znovu.");
            }else
                MessageBox.Show("Prosím vyplňte všechny kolonky.");
        }

        private void FormPrihlaseni_Load(object sender, EventArgs e)
        {
            bool souborBankovniUcetExistuje = File.Exists("Klienti.csv");

            if (!souborBankovniUcetExistuje)
            {
                StreamWriter streamWriter = new StreamWriter("Klienti.csv", false, Encoding.UTF8);
                streamWriter.WriteLine("Jméno;Příjmení;Příhlašovací jméno;Heslo");
                streamWriter.Close();
            }

            bool souborBeznyUcetExistuje = File.Exists("BezneUcty.csv");

            if (!souborBeznyUcetExistuje)
            {
                StreamWriter streamWriter = new StreamWriter("BezneUcty.csv", false, Encoding.UTF8);
                streamWriter.WriteLine("Klient;Typ účtu; Číslo účtu; Částka");
                streamWriter.Close();
            }

            bool souborSporiciUcetExistuje = File.Exists("SporiciUcty.csv");

            if (!souborBankovniUcetExistuje)
            {
                StreamWriter streamWriter = new StreamWriter("SporiciUcty.csv", false, Encoding.UTF8);
                streamWriter.WriteLine("Klient;Typ účtu; Číslo účtu; Částka");
                streamWriter.Close();
            }

            using (StreamReader streamReader = new StreamReader("Klienti.csv", Encoding.UTF8))
            {
                streamReader.ReadLine();
                string radekCSV;
                while (!streamReader.EndOfStream)
                {
                    radekCSV = streamReader.ReadLine();
                    Globalni.seznamKlientu.Add(new Klient(radekCSV));
                }
            }
            using (StreamReader streamReader = new StreamReader("BezneUcty.csv", Encoding.UTF8))
            {
                streamReader.ReadLine();
                string radekCSV;
                while (!streamReader.EndOfStream)
                {
                    radekCSV = streamReader.ReadLine();
                    Globalni.seznamBeznychUctu.Add(new BeznyUcet(radekCSV));
                }
            }
            using (StreamReader streamReader = new StreamReader("SporiciUcty.csv", Encoding.UTF8))
            {
                streamReader.ReadLine();
                string radekCSV;
                while (!streamReader.EndOfStream)
                {
                    radekCSV = streamReader.ReadLine();
                    Globalni.seznamSporicichUctu.Add(new SporiciUcet(radekCSV));
                }
            }
        }
    }
}
