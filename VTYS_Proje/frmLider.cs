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
    public partial class frmLider : Form
    {
        public frmLider()
        {
            InitializeComponent();
        }

        private void btnItirazlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var itirazlar = new frmItirazlar();
            itirazlar.Closed += (s, args) => this.Close();
            itirazlar.Show();
        }
    }
}
