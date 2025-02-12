using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VTYS_Proje
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private static string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=vtys_proje;Integrated Security=True;Encrypt=False";
        public static SqlConnection connect = new SqlConnection(connectionString);

        public static int sicilNo;

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool isThere = false;
            string query = "SELECT * FROM kullanici_giris";
                 

            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (txtKullaniciAd.Text == reader["kullanici_adi"].ToString() && txtParola.Text == reader["sifre"].ToString() && cmbTip.Text == reader["tip_adi"].ToString())
                {
                    isThere = true;
                    sicilNo = reader.GetInt32(3);
                    break;
                }
                else
                    isThere = false;
            }
            connect.Close();                    

            if (isThere)
            {
                if (cmbTip.Text == "Asistan")
                {
                    this.Hide();
                    var asistan = new frmAsistan();
                    asistan.Closed += (s, args) => this.Close();
                    asistan.Show();
                }

                else if (cmbTip.Text == "Takım Lideri")
                {
                    this.Hide();
                    var lider = new frmLider();
                    lider.Closed += (s, args) => this.Close();
                    lider.Show();
                }

                else if (cmbTip.Text == "Gurup Yöneticisi")
                {
                    this.Hide();
                    var yonetici = new frmYonetici();
                    yonetici.Closed += (s, args) => this.Close();
                    yonetici.Show();
                }

            }
            
            else
                MessageBox.Show("Hatalı giriş yaptınız");      
        }
    }
}
