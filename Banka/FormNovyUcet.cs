using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class FormNovyUcet : Form
    {
        public FormNovyUcet()
        {
            InitializeComponent();
        }

        private void btVytvorit_Click(object sender, EventArgs e)
        {
            bool JsouVyplnenaPoleAHeslaSeShoduji = tbJmeno.Text != string.Empty && tbPrijmeni.Text != string.Empty && tbPrihlasovaciJmeno.Text != string.Empty && tbHeslo.Text != string.Empty && tbHesloZnovu.Text != string.Empty && tbHeslo.Text == tbHesloZnovu.Text;

            if (JsouVyplnenaPoleAHeslaSeShoduji)
            {
                if (tbHeslo.Text == tbHesloZnovu.Text)
                Globalni.seznamKlientu.Add(new Klient(tbJmeno.Text, tbPrijmeni.Text, tbPrihlasovaciJmeno.Text, tbHeslo.Text));
            else MessageBox.Show("Hesla se neshodují.");
        }
    }
}
