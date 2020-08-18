using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class FrmHastaDuzenle : Form
    {
        HastaServis servis = new HastaServis();
        string _id; // formlar da birer class'dır -> boy ve kiloyu aldığımız gibi yapıcı metoddan bu id'yi alabiliriz.
        public FrmHastaDuzenle(string id) 
        {
            InitializeComponent();
            _id = id;
        }

        private void FrmHastaDüzenle_Enter(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

   

            servis.HastaGuncelle(_id, txtAd.Text, // hasta güncellemeyi çağırıp kaydet düğmesine bastığında aşağıdaki şekilde tüm veriler güncellenecek
                txtSoyad.Text,
                Convert.ToSingle(txtBoy.Text),
                Convert.ToSingle(txtKilo.Text));
            this.Close(); //this: içinde bulunduğu sınıfın bellek içinde oluşturduğu örneğini ifade ediyor yani hasta düzenle formu!
            

        }

        private void FrmHastaDuzenle_Load(object sender, EventArgs e)
        {
          var hasta =  servis.IdDenHastaAl(_id);
            txtAd.Text = hasta.Ad;
            txtSoyad.Text = hasta.Soyad;
            txtBoy.Text = hasta.Boy.ToString();
            txtKilo.Text = hasta.Kilo.ToString();

        }
    }
}
