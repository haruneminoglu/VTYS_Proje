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

namespace VTYS_Proje
{
    public partial class frmItirazlarim : Form
    {
        public frmItirazlarim()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;

        private void itirazlarimiListele()
        {
            string query = "SELECT * FROM itirazlarimi_listele(" + frmLogin.sicilNo + ")";

            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["aciklama"].ToString();
                ekle.SubItems.Add(reader["cevap"].ToString());
                ekle.SubItems.Add(reader["durum"].ToString());
                listView1.Items.Add(ekle);
            }
            connect.Close();
        }
        private void frmItirazlarim_Load(object sender, EventArgs e)
        {
            itirazlarimiListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            itirazlarimiListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var asistan = new frmAsistan();
            asistan.Closed += (s, args) => this.Close();
            asistan.Show();
        }
    }
}
