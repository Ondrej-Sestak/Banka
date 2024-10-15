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

            lbJmeno.Text = klient.Jmeno +
        }

        private void btBeznyUcet_Click(object sender, EventArgs e)
        {

        }
    }
}
