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
using System.Net;
using System.Net.Mail;


namespace VTYS_Proje
{
    public partial class frmItirazEt : Form
    {
        public frmItirazEt()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;
                     
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();         
        }

        string aciklama;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("itiraz_ekle",connect);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@aciklama", richTextBox1.Text);
            command.Parameters.AddWithValue("@prim", frmPrim.primID);
            command.Parameters.AddWithValue("@asistan",frmLogin.sicilNo);
            command.ExecuteNonQuery();
            connect.Close();

            aciklama = richTextBox1.Text;
            richTextBox1.Clear();

            MessageBox.Show("İtirazınız gönderildi");
            btnPosta.Enabled = true;

            
        }

        private void btnPosta_Click(object sender, EventArgs e)
        {
            string tamIsim;
            string email, pass, messageBody;
           
            string query = "SELECT * FROM e_postalar WHERE sicil_no=" + frmLogin.sicilNo;

            connect.Open();
            SqlCommand command = new SqlCommand(query,connect);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            email = reader["e_posta"].ToString();
            tamIsim = reader["ad"].ToString()+" "+ reader["soyad"].ToString();
            
            connect.Close();

            MailMessage message = new MailMessage();           

            pass = "grupYonetici_123";
            messageBody = "Takım lideriniz "+tamIsim.TrimEnd()+" sicil numarası "+frmLogin.sicilNo+
            " olan asistan tarafından itiraz almıştır.\n İtiraz metni: " +aciklama;

            message.To.Add(email);
            message.From = new MailAddress(email);
            message.Body = messageBody;
            message.Subject = "İtiraz Metni";

            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com");

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(email, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Grup yöneticisi bilgilendirildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
