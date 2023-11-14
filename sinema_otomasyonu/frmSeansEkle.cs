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
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }
        string seans = "";
        private void RadioButtonSeçiliyse()
        {
            if(radioButton1.Checked==true ) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
        }
        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            RadioButtonSeçiliyse();
            if (seans!= "")
            {
                
                filmseansi.SeansEkle(comboFilm.Text,comboSalon.Text,dateTimePicker1.Text,seans);
                MessageBox.Show("Seans Eklendi.", "Kayıt");

            }
            else if(seans=="")
            {
                MessageBox.Show("Seans Seçilmemiş.", "Uyarı");
            }
            comboSalon.Text = "";
            comboFilm.Text = "";
            dateTimePicker1.Text= DateTime.Now.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach(Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }

            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if(yeni==bugün)
            {
                foreach(Control item in groupBox1.Controls)
                {
                    if(DateTime.Parse(DateTime.Now.ToShortTimeString())>DateTime.Parse(item.Text)) 
                    {
                       item.Enabled= false;

                    }
                }
                using (SqlConnection baglanti = new SqlConnection(conString))
                {
                    Tarihi_Karşılaştır(baglanti);
                }
            }
            else if (yeni>bugün)
            {
                
            }
            else if (yeni<bugün)
            {
                MessageBox.Show("Geçmiş zamanda işlem yapılamaz!!!", "Uyarı");
                dateTimePicker1.Text= DateTime.Now.ToShortDateString();
            }

        }


        private void Tarihi_Karşılaştır(SqlConnection baglanti)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from seans_bilgiler where salonadi='" + comboSalon.Text + "' and tarih= '" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (reader["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }

        sinemaTableAdapters.Seans_BilgilerTableAdapter filmseansi = new sinemaTableAdapters.Seans_BilgilerTableAdapter();
        public string conString = "Data Source=emre-samuk;Initial Catalog=sinema_otomasyon_kopya;Integrated Security=True";
        private void frmSeansEkle_Load(object sender, EventArgs e)
        {
            FilmveSalonGoster(comboFilm,"select *from Film_Bilgiler","filmadi");
            FilmveSalonGoster(comboSalon,"select *from Salon_Bilgiler", "salonadi");
            label1.BackColor=Color.Transparent; 
            label2.BackColor=Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
        }
      
        private void FilmveSalonGoster(ComboBox combo, string sql, string sql2)
        {
            using (SqlConnection baglanti = new SqlConnection(conString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sql, baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    combo.Items.Add(reader[sql2].ToString());
                }
            }
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
