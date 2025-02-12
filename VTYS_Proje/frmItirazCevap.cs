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
    public partial class frmItirazCevap : Form
    {
        public frmItirazCevap()
        {
            InitializeComponent();
        }

        SqlConnection connect = frmLogin.connect;

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        string durum;
        private void btnGonder_Click(object sender, EventArgs e)
        {                     
            string query = "UPDATE tblItiraz SET cevap=@cevap,durum=@durum WHERE itiraz_id=" + frmItirazlar.itirazID; ;

            connect.Open();
            SqlCommand command = new SqlCommand(query,connect);
            command.Parameters.AddWithValue("@cevap", richTextBox1.Text.ToString());
            command.Parameters.AddWithValue("@durum", comboBox1.Text.ToString());
            command.ExecuteNonQuery();
            connect.Close();

            durum = comboBox1.Text.ToString();

            richTextBox1.Clear();
            comboBox1.Text = "";

            MessageBox.Show("Cevabınız gönderildi");
            btnPosta.Enabled = true;
        }

        private void btnPosta_Click(object sender, EventArgs e)
        {
            string tamIsim;
            string email, pass, messageBody;          
            string query = "SELECT * FROM e_postalar WHERE lider=" + frmLogin.sicilNo;

            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            email = reader["e_posta"].ToString();
            tamIsim = reader["ad"].ToString() + " " + reader["soyad"].ToString();

            connect.Close();

            MailMessage message = new MailMessage();

            pass = "grupYonetici_123";
            messageBody = "Takım lideriniz " + tamIsim.TrimEnd() + " itiraz numarası " + frmItirazlar.itirazID +
            " olan itirazın durumunu "+durum+" olarak değiştirmiştir";

            message.To.Add(email);
            message.From = new MailAddress(email);
            message.Body = messageBody;
            message.Subject = "İtiraz Durumu";

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
