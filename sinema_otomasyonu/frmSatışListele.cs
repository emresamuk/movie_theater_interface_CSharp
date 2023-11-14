using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sinema_otomasyonu
{
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Satis_BilgilerTableAdapter satisListesi = new sinemaTableAdapters.Satis_BilgilerTableAdapter();
        private void frmSatışListele_Load(object sender, EventArgs e)
        {         
            ToplamÜcretHesaplama();
        }

        private void ToplamÜcretHesaplama()
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView2.Rows[i].Cells["ucret"].Value);
                label1.Text = "Toplam Satış Geliri= " + toplam + "TL";
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ToplamÜcretHesaplama();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = satisListesi.SatışListesi2();

            ToplamÜcretHesaplama();
        }
    }
}
