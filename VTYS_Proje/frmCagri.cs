using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_Proje
{
    public partial class frmCagri : Form
    {
        public frmCagri()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;
  
        private void cagriListele()
        {                   
            string query = "SELECT * FROM cagri_listele(" + frmLogin.sicilNo+ ")";

            connect.Open();        
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {              
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["ad"].ToString();
                ekle.SubItems.Add(reader["soyad"].ToString());
                ekle.SubItems.Add(reader["konu"].ToString());

                DateTime tarih = DateTime.Parse(reader["tarih"].ToString());
                string txtTarih = tarih.ToString("dd-MM-yyyy");
                ekle.SubItems.Add(txtTarih);

                ekle.SubItems.Add(reader["baslama"].ToString());
                ekle.SubItems.Add(reader["bitis"].ToString());
                ekle.SubItems.Add(reader["durum"].ToString());
                listView1.Items.Add(ekle);
            }
            connect.Close();
        }
    
        private void btnYeniCagri_Click(object sender, EventArgs e)
        {            
            var yeniCagri = new frmYeniCagri();
            yeniCagri.Closed += (s, args) => this.Close();
            yeniCagri.Show();
        }

        private void frmCagri_Load(object sender, EventArgs e)
        {
            cagriListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            cagriListele();
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
