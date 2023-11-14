using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

        private void FrmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }
        sinemaTableAdapters.Salon_BilgilerTableAdapter salon= new sinemaTableAdapters.Salon_BilgilerTableAdapter();
        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkle(txtSalonAdi.Text);
                MessageBox.Show("Salon Başarıyla Eklendi", "Kayit");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı Salonu Daha Önce Eklediniz!!!");
            }
            txtSalonAdi.Text = " ";
        }

        private void frmSalonEkle_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e )
        {
            frmAnasayfa anasayfa= new frmAnasayfa();
            anasayfa.Show();
        }
    }
}
