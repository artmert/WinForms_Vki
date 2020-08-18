namespace WindowsFormsApp1
{
    partial class FrmHastaListesi
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
            this.components = new System.ComponentModel.Container();
            this.grdHastaListesi = new System.Windows.Forms.DataGridView();
            this.ctxMenuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.rbtnSoyad = new System.Windows.Forms.RadioButton();
            this.rbtnAd = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdHastaListesi)).BeginInit();
            this.ctxMenuGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdHastaListesi
            // 
            this.grdHastaListesi.AllowUserToAddRows = false;
            this.grdHastaListesi.AllowUserToDeleteRows = false;
            this.grdHastaListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHastaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHastaListesi.ContextMenuStrip = this.ctxMenuGrid;
            this.grdHastaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHastaListesi.Location = new System.Drawing.Point(0, 0);
            this.grdHastaListesi.MultiSelect = false;
            this.grdHastaListesi.Name = "grdHastaListesi";
            this.grdHastaListesi.ReadOnly = true;
            this.grdHastaListesi.RowHeadersVisible = false;
            this.grdHastaListesi.RowHeadersWidth = 72;
            this.grdHastaListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHastaListesi.Size = new System.Drawing.Size(578, 582);
            this.grdHastaListesi.TabIndex = 0;
            // 
            // ctxMenuGrid
            // 
            this.ctxMenuGrid.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ctxMenuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.toolStripSeparator1,
            this.silToolStripMenuItem});
            this.ctxMenuGrid.Name = "ctxMenuGrid";
            this.ctxMenuGrid.Size = new System.Drawing.Size(271, 120);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.DuzenleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltre);
            this.groupBox1.Controls.Add(this.rbtnSoyad);
            this.groupBox1.Controls.Add(this.rbtnAd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(27, 55);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(276, 39);
            this.txtFiltre.TabIndex = 1;
            this.txtFiltre.TextChanged += new System.EventHandler(this.TxtFiltre_TextChanged);
            // 
            // rbtnSoyad
            // 
            this.rbtnSoyad.AutoSize = true;
            this.rbtnSoyad.Location = new System.Drawing.Point(92, 25);
            this.rbtnSoyad.Name = "rbtnSoyad";
            this.rbtnSoyad.Size = new System.Drawing.Size(121, 36);
            this.rbtnSoyad.TabIndex = 0;
            this.rbtnSoyad.Text = "Soyad";
            this.rbtnSoyad.UseVisualStyleBackColor = true;
            // 
            // rbtnAd
            // 
            this.rbtnAd.AutoSize = true;
            this.rbtnAd.Checked = true;
            this.rbtnAd.Location = new System.Drawing.Point(27, 25);
            this.rbtnAd.Name = "rbtnAd";
            this.rbtnAd.Size = new System.Drawing.Size(75, 36);
            this.rbtnAd.TabIndex = 0;
            this.rbtnAd.TabStop = true;
            this.rbtnAd.Text = "Ad";
            this.rbtnAd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdHastaListesi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 582);
            this.panel1.TabIndex = 2;
            // 
            // FrmHastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHastaListesi";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmHastaListesi";
            this.Load += new System.EventHandler(this.FrmHastaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHastaListesi)).EndInit();
            this.ctxMenuGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHastaListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.RadioButton rbtnSoyad;
        private System.Windows.Forms.RadioButton rbtnAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuGrid;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}