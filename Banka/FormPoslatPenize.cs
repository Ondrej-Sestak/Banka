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
    public partial class FormPoslatPenize : Form
    {
        public FormPoslatPenize()
        {
            InitializeComponent();
        }

        public Klient aktualniKlient;
        public BeznyUcet aktualniBeznyUcet;
        public SporiciUcet aktualniSporiciUcet;

        BeznyUcet protiUcet;

        List<BeznyUcet> bezneUcty = new List<BeznyUcet>();

        bool JsmeNaSporicimUctu => aktualniSporiciUcet != null;
        bool JsmeNaBeznemUctu => aktualniBeznyUcet != null;
        private void FormPoslatPenize_Load(object sender, EventArgs e)
        {
            if (JsmeNaBeznemUctu)
            {
                lbNazevUctu.Text = aktualniBeznyUcet.NazevUctu;
                foreach (BeznyUcet beznyUcet in Globalni.seznamBeznychUctu)
                {
                    if (beznyUcet.CisloUctu != aktualniBeznyUcet.CisloUctu)
                        bezneUcty.Add(beznyUcet);
                }
            }
            else if (JsmeNaSporicimUctu)
            {
                lbNazevUctu.Text = aktualniSporiciUcet.NazevUctu;
                foreach (BeznyUcet beznyUcet in aktualniKlient.BezneUcty)
                {
                    bezneUcty.Add(beznyUcet);
                }
            }

            foreach (BeznyUcet beznyUcet in bezneUcty)
            {
                cbUcty.Items.Add(beznyUcet);
            }
        }

        private void btPoslat_Click(object sender, EventArgs e)
        {
            if (cbUcty.SelectedIndex != -1)
            {
                if (JsmeNaBeznemUctu)
                {
                    aktualniBeznyUcet.PosliPenize(nupCastka.Value);
                    protiUcet.PrijmiPenize(nupCastka.Value);
                }
                else if (JsmeNaSporicimUctu)
                {
                    aktualniSporiciUcet.PosliPenize(nupCastka.Value);
                    protiUcet.PrijmiPenize(nupCastka.Value);
                }
            }
        }

        private void cbUcty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUcty.SelectedIndex != -1) {
                protiUcet = bezneUcty[cbUcty.SelectedIndex];
            }
            MessageBox.Show(protiUcet.ToString());
        }
    }
}
