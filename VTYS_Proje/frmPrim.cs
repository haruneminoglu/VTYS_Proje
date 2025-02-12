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
    public partial class frmPrim : Form
    {
        public frmPrim()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;


        private void primListele()
        {           
            string query = "SELECT * FROM prim_listele(" + frmLogin.sicilNo + ")";

            connect.Open();            
            SqlCommand command = new SqlCommand(query, connect);          
            SqlDataReader reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["ay"].ToString();
                ekle.SubItems.Add(reader["aylik_prim"].ToString());             
                listView1.Items.Add(ekle);
            }         
            connect.Close();
        }

        public static int primID;
        private void primIdBul()
        {            
            string query = "SELECT MAX(prim_id) FROM prim_listele(" + frmLogin.sicilNo+ ")";

            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            primID = reader.GetInt32(0);
            connect.Close();
        }

        private void btnItirazEt_Click(object sender, EventArgs e)
        {
            var itirazEt = new frmItirazEt();
            itirazEt.Closed += (s, args) => this.Close();
            itirazEt.Show();
        }

        private void frmPrim_Load(object sender, EventArgs e)
        {
            primListele();
            primIdBul();
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
