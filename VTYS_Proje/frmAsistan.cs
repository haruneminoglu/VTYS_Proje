using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_Proje
{
    public partial class frmAsistan : Form
    {
        public frmAsistan()
        {
            InitializeComponent();
        }

        private void btnCagriListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cagri = new frmCagri();
            cagri.Closed += (s, args) => this.Close();
            cagri.Show();
        }

        private void btnPrimListe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prim = new frmPrim();
            prim.Closed += (s, args) => this.Close();
            prim.Show();
        }

        private void btnItirazlarim_Click(object sender, EventArgs e)
        {
            this.Hide();
            var itirazlarim = new frmItirazlarim();
            itirazlarim.Closed += (s, args) => this.Close();
            itirazlarim.Show();
        }
    }
}
