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
        }

        Klient aktualniKlient;

        private void btBeznyUcet_Click(object sender, EventArgs e)
        {
            BeznyUcet beznyUcet = new BeznyUcet(aktualniKlient.Jmeno + " " + aktualniKlient.Prijmeni);
            aktualniKlient.BezneUcty.Add(beznyUcet);
            Globalni.seznamBeznychUctu.Add(beznyUcet);
            lboxBezneUcty.Items.Add(beznyUcet);
        }

        private void btSporiciUcet_Click(object sender, EventArgs e)
        {
            SporiciUcet sporiciUcet = new SporiciUcet(aktualniKlient.Jmeno + " " + aktualniKlient.Prijmeni);
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
