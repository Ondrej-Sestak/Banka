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

            FormClosing += new FormClosingEventHandler(FormPrihlaseni_FormClosing);
        }

        private void btVytvoritUcet_Click(object sender, EventArgs e)
        {
            FormNovyUcet formNovyUcet = new FormNovyUcet();
            formNovyUcet.ShowDialog();
        }

        private void btPrihlasit_Click(object sender, EventArgs e)
        {
            if (tbPrihlasovaciJmeno.Text != string.Empty && tbHeslo.Text != string.Empty)
            {
                bool UcetBylNajit = false;
                foreach (Klient klient in Globalni.seznamKlientu)
                {
                    if (klient.PrihlasovaciJmeno == tbPrihlasovaciJmeno.Text && klient.Heslo == tbHeslo.Text)
                    {
                        FormSpravaUctu formSpravaUctu = new FormSpravaUctu(klient);
                        formSpravaUctu.ShowDialog();
                        UcetBylNajit = true;
                        break;
                    }
                }
                if (!UcetBylNajit)
                    MessageBox.Show("Zadané údaje nejsou správné, zkuste to znovu.");
            }else
                MessageBox.Show("Prosím vyplňte všechny kolonky.");
        }

        private void FormPrihlaseni_Load(object sender, EventArgs e)
        {
            Globalni.NactiSeznamKlientu();
            Globalni.NactiSeznamBeznychUctu();
            Globalni.NactiSeznamSporicichUctu();
        }

        private void FormPrihlaseni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globalni.UlozSeznamKlientu();
            Globalni.UlozSeznamBeznychUctu();
            Globalni.UlozSeznamSporicichUctu();
        }
    }
}
