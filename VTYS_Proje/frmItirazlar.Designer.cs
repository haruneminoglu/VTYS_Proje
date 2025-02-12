namespace VTYS_Proje
{
    partial class frmItirazlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCevapla = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chItiraz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSicil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYenile = new System.Windows.Forms.Button();
            this.chSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCevapla
            // 
            this.btnCevapla.BackColor = System.Drawing.Color.Black;
            this.btnCevapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCevapla.ForeColor = System.Drawing.Color.White;
            this.btnCevapla.Location = new System.Drawing.Point(476, 528);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(159, 56);
            this.btnCevapla.TabIndex = 3;
            this.btnCevapla.Text = "Cevapla";
            this.btnCevapla.UseVisualStyleBackColor = false;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItiraz,
            this.chSicil,
            this.chAd,
            this.chSoyad,
            this.chAciklama,
            this.chAy,
            this.chDurum});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(40, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1050, 451);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chItiraz
            // 
            this.chItiraz.Text = "İtiraz Id";
            this.chItiraz.Width = 150;
            // 
            // chSicil
            // 
            this.chSicil.Text = "Sicil No";
            this.chSicil.Width = 150;
            // 
            // chAd
            // 
            this.chAd.Text = "Ad  ";
            this.chAd.Width = 150;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.Black;
            this.btnYenile.Location = new System.Drawing.Point(40, 528);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(159, 56);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // chSoyad
            // 
            this.chSoyad.Text = "Soyad";
            this.chSoyad.Width = 150;
            // 
            // chAciklama
            // 
            this.chAciklama.Text = "Açıklama";
            this.chAciklama.Width = 150;
            // 
            // chAy
            // 
            this.chAy.Text = "Ay";
            this.chAy.Width = 150;
            // 
            // chDurum
            // 
            this.chDurum.Text = "Durum";
            this.chDurum.Width = 150;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.White;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.Location = new System.Drawing.Point(931, 528);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(159, 56);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "Geri dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(442, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "YAPILAN İTİRAZLAR";
            // 
            // frmItirazlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCevapla);
            this.Name = "frmItirazlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İtirazlar Listesi";
            this.Load += new System.EventHandler(this.frmItirazlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ColumnHeader chItiraz;
        private System.Windows.Forms.ColumnHeader chSicil;
        private System.Windows.Forms.ColumnHeader chAd;
        private System.Windows.Forms.ColumnHeader chSoyad;
        private System.Windows.Forms.ColumnHeader chAciklama;
        private System.Windows.Forms.ColumnHeader chAy;
        private System.Windows.Forms.ColumnHeader chDurum;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label1;
    }
}