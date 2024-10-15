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
            foreach (Klient klient in Globalni.seznamKlientu)
            {
                if (klient.Jmeno == tbPrihlasovaciJmeno.Text)
                    klient.BezneUcty.Add(new BeznyUcet());
            }
        }
    }
}
