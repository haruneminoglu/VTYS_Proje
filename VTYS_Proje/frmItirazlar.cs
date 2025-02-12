using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYS_Proje
{
    public partial class frmItirazlar : Form
    {
        public frmItirazlar()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;

        private void itirazListele()
        {
            string query = "SELECT * FROM itiraz_listele(" + frmLogin.sicilNo+ ")";

            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["itiraz_id"].ToString();
                ekle.SubItems.Add(reader["sicil_no"].ToString());
                ekle.SubItems.Add(reader["ad"].ToString());
                ekle.SubItems.Add(reader["soyad"].ToString());
                ekle.SubItems.Add(reader["aciklama"].ToString());
                ekle.SubItems.Add(reader["ay"].ToString());
                ekle.SubItems.Add(reader["durum"].ToString());
                listView1.Items.Add(ekle);
            }
            connect.Close();
        }

        private void frmItirazlar_Load(object sender, EventArgs e)
        {
            itirazListele();
        }

        public static int itirazID = 0;

        private void btnCevapla_Click(object sender, EventArgs e)
        {      
            
            itirazID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                           
             var cevap = new frmItirazCevap();
             cevap.Closed += (s, args) => this.Close();
             cevap.Show();              
            
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lider = new frmLider();
            lider.Closed += (s, args) => this.Close();
            lider.Show();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            itirazListele();
        }
    }
}
