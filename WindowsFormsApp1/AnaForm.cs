
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void YeniHastaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmYeniHasta f = new FrmYeniHasta();
            f.ShowDialog();
        }

        private void HastaListesiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmHastaListesi f = new FrmHastaListesi();
            f.ShowDialog();
        }

        
    }
}
