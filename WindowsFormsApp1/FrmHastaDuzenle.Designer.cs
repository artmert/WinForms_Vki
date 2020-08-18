namespace WindowsFormsApp1
{
    partial class FrmHastaDuzenle
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
            this.frmHastaDüzenle = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.frmHastaDüzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmHastaDüzenle
            // 
            this.frmHastaDüzenle.Controls.Add(this.btnKaydet);
            this.frmHastaDüzenle.Controls.Add(this.label4);
            this.frmHastaDüzenle.Controls.Add(this.label1);
            this.frmHastaDüzenle.Controls.Add(this.label3);
            this.frmHastaDüzenle.Controls.Add(this.txtAd);
            this.frmHastaDüzenle.Controls.Add(this.label2);
            this.frmHastaDüzenle.Controls.Add(this.txtSoyad);
            this.frmHastaDüzenle.Controls.Add(this.txtBoy);
            this.frmHastaDüzenle.Controls.Add(this.txtKilo);
            this.frmHastaDüzenle.Location = new System.Drawing.Point(18, 41);
            this.frmHastaDüzenle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmHastaDüzenle.Name = "frmHastaDüzenle";
            this.frmHastaDüzenle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmHastaDüzenle.Size = new System.Drawing.Size(765, 368);
            this.frmHastaDüzenle.TabIndex = 5;
            this.frmHastaDüzenle.TabStop = false;
            this.frmHastaDüzenle.Text = "Hasta Düzenle";
            this.frmHastaDüzenle.Enter += new System.EventHandler(this.FrmHastaDüzenle_Enter);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(522, 255);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(212, 75);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kilo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boy";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(32, 98);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(318, 29);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(384, 98);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(348, 29);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(32, 200);
            this.txtBoy.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(318, 29);
            this.txtBoy.TabIndex = 1;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(384, 200);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(348, 29);
            this.txtKilo.TabIndex = 1;
            // 
            // FrmHastaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.frmHastaDüzenle);
            this.Name = "FrmHastaDuzenle";
            this.Text = "FrmHastaDuzenle";
            this.Load += new System.EventHandler(this.FrmHastaDuzenle_Load);
            this.frmHastaDüzenle.ResumeLayout(false);
            this.frmHastaDüzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox frmHastaDüzenle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
    }
}