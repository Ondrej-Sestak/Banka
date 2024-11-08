﻿using System;
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
        BeznyUcet aktualniBeznyUcet;
        SporiciUcet aktualniSporiciUcet;


        private void btBeznyUcet_Click(object sender, EventArgs e)
        {
            BeznyUcet beznyUcet = new BeznyUcet("Běžný účet",aktualniKlient.Jmeno + " " + aktualniKlient.Prijmeni);
            aktualniKlient.BezneUcty.Add(beznyUcet);
            Globalni.seznamBeznychUctu.Add(beznyUcet);
            lboxBezneUcty.Items.Add(beznyUcet);
            btSporiciUcetVytvorit.Visible = true;
            btBeznyPoslat.Visible = true;
        }

        private void btSporiciUcetVytvorit_Click(object sender, EventArgs e)
        {
            SporiciUcet sporiciUcet = new SporiciUcet("Spořící účet", aktualniKlient.Jmeno + " " + aktualniKlient.Prijmeni);
            aktualniKlient.SporiciUcty.Add(sporiciUcet);
            Globalni.seznamSporicichUctu.Add(sporiciUcet);
            lboxSporiciUcty.Items.Add(sporiciUcet);
            btSporiciPoslat.Visible = true;
        }

        private void FormSpravaUctu_Load(object sender, EventArgs e)
        {
            if (aktualniKlient.BezneUcty.Count != 0) {
                foreach (BeznyUcet beznyUcet in aktualniKlient.BezneUcty)
                {
                    lboxBezneUcty.Items.Add(beznyUcet);
                }
                btBeznyPoslat.Visible = true;
            }

            if (aktualniKlient.SporiciUcty.Count != 0)
            {
                foreach (SporiciUcet sporiciUcet in aktualniKlient.SporiciUcty)
                {
                    lboxSporiciUcty.Items.Add(sporiciUcet);
                }
                btSporiciPoslat.Visible = true;
            }
        }

        private void btBeznyPoslat_Click(object sender, EventArgs e)
        {
            if(aktualniBeznyUcet != null)
            {
                FormPoslatPenize formPoslatPenize = new FormPoslatPenize();
                formPoslatPenize.aktualniKlient = aktualniKlient;
                formPoslatPenize.aktualniBeznyUcet = aktualniBeznyUcet;
                formPoslatPenize.ShowDialog();
            }
        }
        private void btSporiciPoslat_Click(object sender, EventArgs e)
        {
            if(aktualniSporiciUcet != null)
            {
                FormPoslatPenize formPoslatPenize = new FormPoslatPenize();
                formPoslatPenize.aktualniKlient = aktualniKlient;
                formPoslatPenize.aktualniSporiciUcet = aktualniSporiciUcet;
                formPoslatPenize.ShowDialog();
            }
        }

        private void lboxBezneUcty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxBezneUcty.SelectedIndex != -1)
                aktualniBeznyUcet = (BeznyUcet)lboxBezneUcty.SelectedItem;
            else
                aktualniBeznyUcet = null;
        }

        private void lboxSporiciUcty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxSporiciUcty.SelectedIndex != -1)
                aktualniSporiciUcet = (SporiciUcet)lboxSporiciUcty.SelectedItem;
            else
                aktualniSporiciUcet = null;
        }
    }
}
