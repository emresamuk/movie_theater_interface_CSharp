using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sinema_otomasyonu
{
    public partial class frmSeansGörüntüle : Form
    {
        public frmSeansGörüntüle()
        {
            InitializeComponent();
        }
        
        public string conString = "Data Source=emre-samuk;Initial Catalog=sinema_otomasyon_kopya;Integrated Security=True";
        DataTable tablo = new DataTable();
        private void SeansListesi(string sql)
        {
            using (SqlConnection baglanti = new SqlConnection(conString))
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }
        private void frmSeansGörüntüle_Load(object sender, EventArgs e)
        {
            tablo.Clear();
           SeansListesi("select *from seans_bilgiler where tarih like '" + dateTimePicker2.Text + "'");

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           tablo.Clear();
           SeansListesi("select *from seans_bilgiler where tarih like '" + dateTimePicker2.Text + "'");
        }

        private void btnSeansGoruntuleme_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select *from seans_bilgiler ");
        }
    }
}
