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
        private BeznyUcet ucetPrijimajiciPenize;

        bool JsmeNaSporicimUctu => aktualniSporiciUcet != null;
        bool JsmeNaBeznemUctu => aktualniBeznyUcet != null;
        private void FormPoslatPenize_Load(object sender, EventArgs e)
        {
            if (JsmeNaBeznemUctu)
            {
                lbNazevUctu.Text = aktualniBeznyUcet.NazevUctu;
                foreach (BeznyUcet beznyUcet in Globalni.seznamBeznychUctu)
                {
                    if(beznyUcet.CisloUctu != aktualniBeznyUcet.CisloUctu)
                        cbUcty.Items.Add(beznyUcet.ZobrazUcet());
                }
            }
            else if(JsmeNaSporicimUctu)
            {
                lbNazevUctu.Text = aktualniSporiciUcet.NazevUctu;
                foreach (BeznyUcet beznyUcet in aktualniKlient.BezneUcty)
                {
                    cbUcty.Items.Add(beznyUcet);
                }
            }
        }

        private void btPoslat_Click(object sender, EventArgs e)
        {
            if (JsmeNaBeznemUctu){
                aktualniBeznyUcet.PosliPenize(nupCastka.Value);
                cbUcty.SelectedItem = ucetPrijimajiciPenize;
                ucetPrijimajiciPenize.PrijmiPenize(nupCastka.Value);
            }
        }
    }
}
