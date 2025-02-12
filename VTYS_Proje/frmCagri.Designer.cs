namespace VTYS_Proje
{
    partial class frmCagri
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
            this.btnYeniCagri = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKonu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBaslama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBitis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYeniCagri
            // 
            this.btnYeniCagri.BackColor = System.Drawing.Color.Black;
            this.btnYeniCagri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniCagri.ForeColor = System.Drawing.Color.White;
            this.btnYeniCagri.Location = new System.Drawing.Point(500, 529);
            this.btnYeniCagri.Name = "btnYeniCagri";
            this.btnYeniCagri.Size = new System.Drawing.Size(144, 57);
            this.btnYeniCagri.TabIndex = 0;
            this.btnYeniCagri.Text = "Yeni çağrı";
            this.btnYeniCagri.UseVisualStyleBackColor = false;
            this.btnYeniCagri.Click += new System.EventHandler(this.btnYeniCagri_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAd,
            this.chSoyad,
            this.chKonu,
            this.chTarih,
            this.chBaslama,
            this.chBitis,
            this.chDurum});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1050, 452);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chAd
            // 
            this.chAd.Text = "Ad";
            this.chAd.Width = 150;
            // 
            // chSoyad
            // 
            this.chSoyad.Text = "Soyad";
            this.chSoyad.Width = 150;
            // 
            // chKonu
            // 
            this.chKonu.Text = "Konu";
            this.chKonu.Width = 150;
            // 
            // chTarih
            // 
            this.chTarih.Text = "Tarih";
            this.chTarih.Width = 150;
            // 
            // chBaslama
            // 
            this.chBaslama.Text = "Başlama";
            this.chBaslama.Width = 150;
            // 
            // chBitis
            // 
            this.chBitis.Text = "Bitiş";
            this.chBitis.Width = 150;
            // 
            // chDurum
            // 
            this.chDurum.Text = "Durum";
            this.chDurum.Width = 150;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.Black;
            this.btnYenile.Location = new System.Drawing.Point(27, 529);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(144, 57);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.White;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.Location = new System.Drawing.Point(933, 529);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(144, 57);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "Geri dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(464, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÇAĞRI LİSTESİ";
            // 
            // frmCagri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnYeniCagri);
            this.Name = "frmCagri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Çağrı Listesi";
            this.Load += new System.EventHandler(this.frmCagri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniCagri;
        private System.Windows.Forms.ColumnHeader chAd;
        private System.Windows.Forms.ColumnHeader chSoyad;
        private System.Windows.Forms.ColumnHeader chKonu;
        private System.Windows.Forms.ColumnHeader chTarih;
        private System.Windows.Forms.ColumnHeader chBaslama;
        private System.Windows.Forms.ColumnHeader chBitis;
        private System.Windows.Forms.ColumnHeader chDurum;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label1;
    }
}