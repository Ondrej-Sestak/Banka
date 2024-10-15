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
    public partial class FormSpravaUctu : Form
    {
        public FormSpravaUctu(Klient klient)
        {
            InitializeComponent();

            lbJmeno.Text = klient.Jmeno + " " + klient.Prijmeni;
            aktualniKlient = klient;
            if (aktualniKlient.BezneUcty.Count == 0)
            {
                btSporiciUcetVytvorit.Visible = false;
            }
        }

        Klient aktualniKlient;

        private void btBeznyUcet_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.InputBox("Question?", "Title", "Default Text");
            BeznyUcet beznyUcet = new BeznyUcet("Běžný účet",aktualniKlient.Jmeno + " " + aktualniKlient.Prijmeni);
            aktualniKlient.BezneUcty.Add(beznyUcet);
            Globalni.seznamBeznychUctu.Add(beznyUcet);
            lboxBezneUcty.Items.Add(beznyUcet);
            btSporiciUcetVytvorit.Visible = true;
        }

        private void btSporiciUcetVytvorit_Click(object sender, EventArgs e)
        {
            SporiciUcet sporiciUcet = new SporiciUcet("Spořící účet",aktualniKlient.Jmeno + " " + aktualniKlient.Prijmeni);
            aktualniKlient.SporiciUcty.Add(sporiciUcet);
            Globalni.seznamSporicichUctu.Add(sporiciUcet);
            lboxSporiciUcty.Items.Add(sporiciUcet);
        }

        private void FormSpravaUctu_Load(object sender, EventArgs e)
        {
            if (aktualniKlient.BezneUcty != null) {
                foreach (BeznyUcet beznyUcet in aktualniKlient.BezneUcty)
                {
                    lboxBezneUcty.Items.Add(beznyUcet);
                }
            }


            if (aktualniKlient.SporiciUcty != null)
            {
                foreach (SporiciUcet sporiciUcet in aktualniKlient.SporiciUcty)
                {
                    lboxSporiciUcty.Items.Add(sporiciUcet);
                }
            }
        }
    }
}
