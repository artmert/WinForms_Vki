using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class FrmYeniHasta : Form
    {
        public FrmYeniHasta()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            HastaServis servis = new HastaServis();
            servis.Ekle(txtAd.Text,
                txtSoyad.Text,
                Convert.ToSingle(txtBoy.Text),
                Convert.ToSingle(txtKilo.Text));

            Util.TxtCleaner.Temizle(groupBox1);
        }
    }
}
