using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }
        //sinemaTableAdapters.Film_BilgilerTableAdapter film= new sinemaTableAdapters.Film_BilgilerTableAdapter();
        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //film.FilmEkle(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film Bilgileri Eklendi", "Kayıt");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu filmi daha önceden eklediniz!!!", "Uyarı");
            }
            
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            comboFilmTuru.Text = "";

        }

        private void btnAfisSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation=openFileDialog1.FileName;
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }
    }
}
