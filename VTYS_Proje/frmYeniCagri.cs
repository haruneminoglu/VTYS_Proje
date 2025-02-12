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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYS_Proje
{
    public partial class frmYeniCagri : Form
    {
        public frmYeniCagri()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;
        private void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            cmbKonu.Text = "";
            dtpTarih.CustomFormat = " ";
            dtpBaslangic.CustomFormat = " ";
            dtpBitis.CustomFormat = " ";
            cmbDurum.Text = "";
        }       

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();                  

            SqlCommand cmdMusteri = new SqlCommand("musteri_ekle", connect);
            SqlCommand cmdGorusme = new SqlCommand("gorusme_ekle", connect);
            
            cmdMusteri.CommandType = CommandType.StoredProcedure;                            
            cmdGorusme.CommandType = CommandType.StoredProcedure;

            cmdMusteri.Parameters.AddWithValue("@ad", txtAd.Text);
            cmdMusteri.Parameters.AddWithValue("@soyad", txtSoyad.Text);

            cmdGorusme.Parameters.AddWithValue("@konu", cmbKonu.Text);
            cmdGorusme.Parameters.AddWithValue("@tarih",dtpTarih.Value);
            cmdGorusme.Parameters.AddWithValue("@baslama", dtpBaslangic.Value);
            cmdGorusme.Parameters.AddWithValue("@bitis",dtpBitis.Value );
            cmdGorusme.Parameters.AddWithValue("@durum", cmbDurum.Text);
            cmdGorusme.Parameters.AddWithValue("@sicilNo", frmLogin.sicilNo);

            cmdMusteri.ExecuteNonQuery();
            cmdGorusme.ExecuteNonQuery();
      
            connect.Close();
            temizle();
            MessageBox.Show("Yeni çağrı kaydedildi");
          
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            dtpTarih.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpTarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dtpTarih.CustomFormat = " ";
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            dtpBaslangic.CustomFormat = "HH:mm";
        }

        private void dtpBaslangic_MouseDown(object sender, MouseEventArgs e)
        {
            dtpBaslangic.CustomFormat = "HH:mm";
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            dtpBitis.CustomFormat = "HH:mm";
        }

        private void dtpBitis_MouseDown(object sender, MouseEventArgs e)
        {
            dtpBitis.CustomFormat = "HH:mm";
        }
    }
}
