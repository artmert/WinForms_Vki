using System;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Services;


namespace WindowsFormsApp1
{
    public partial class FrmHastaListesi : Form
    {
        public FrmHastaListesi()
        {
            InitializeComponent();
        }

        HastaServis servis = new HastaServis();
        private void FrmHastaListesi_Load(object sender, EventArgs e)

        {
            GridGuncelle();

        }

        private void GridGuncelle() // değişen hastanın grid'de de güncellenmsi
        {
            grdHastaListesi.DataSource = servis.Filtrele(null, true);
            grdHastaListesi.Columns["Id"].Visible = false; // Id colonu'nu gizledik.
        }

        //private void grdHastaListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void TxtFiltre_TextChanged(object sender, EventArgs e)
        {
            //    grdHastaListesi.DataSource = servis.Filtrele(txtFiltre.Text, rbtnAd.Checked);
            if (rbtnAd.Checked)
            {
                grdHastaListesi.DataSource = servis.Filtrele(txtFiltre.Text, true);
            }
            else
            {
                grdHastaListesi.DataSource = servis.Filtrele(txtFiltre.Text, false);
            }
        }

        private void DuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                                                                                 //yöntem1) grdHastaListesi.SelectedRows[0] --> multiselect'i kapattığım için seçtiğim kolon sadece bir tane olacak ve seçilen sütun 0'ncı indexte olacak her zaman
            string id= grdHastaListesi.CurrentRow.Cells["Id"].Value.ToString(); //value burada object olarak geldiği için bunu string'e çevirdik ve böylece ilgili kayıta ilişkinID'yi elimize almış olduk
            FrmHastaDuzenle f = new FrmHastaDuzenle(id); //sağ tuşla form üzerinde düzenle'ye tıklandığında devreye girer. Fakat şu an formda hiçbirşey yok ,hangi hasta düzenlenecek?. Buradaki id'yi gönderebilirsem o da gider  Servisler'de yer alan IdDenHastaAl metoduyla çekilen ID ile ilgili hastaya ulaşır. 
            f.ShowDialog();
            GridGuncelle();
        }
    }
}
