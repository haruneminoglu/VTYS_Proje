namespace VTYS_Proje
{
    partial class frmPrim
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chAy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnItirazEt = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAy,
            this.chPrim});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(258, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 368);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chAy
            // 
            this.chAy.Text = "Ay";
            this.chAy.Width = 200;
            // 
            // chPrim
            // 
            this.chPrim.Text = "Prim";
            this.chPrim.Width = 200;
            // 
            // btnItirazEt
            // 
            this.btnItirazEt.BackColor = System.Drawing.Color.Black;
            this.btnItirazEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItirazEt.ForeColor = System.Drawing.Color.White;
            this.btnItirazEt.Location = new System.Drawing.Point(368, 449);
            this.btnItirazEt.Name = "btnItirazEt";
            this.btnItirazEt.Size = new System.Drawing.Size(144, 57);
            this.btnItirazEt.TabIndex = 1;
            this.btnItirazEt.Text = "İtiraz et";
            this.btnItirazEt.UseVisualStyleBackColor = false;
            this.btnItirazEt.Click += new System.EventHandler(this.btnItirazEt_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(715, 461);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(144, 57);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "Geri dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(374, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRİM LİSTESİ";
            // 
            // frmPrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnItirazEt);
            this.Controls.Add(this.listView1);
            this.Name = "frmPrim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aylık Prim Listesi";
            this.Load += new System.EventHandler(this.frmPrim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnItirazEt;
        private System.Windows.Forms.ColumnHeader chAy;
        private System.Windows.Forms.ColumnHeader chPrim;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label1;
    }
}