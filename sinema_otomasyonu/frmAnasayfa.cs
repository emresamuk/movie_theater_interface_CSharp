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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sinema_otomasyonu
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=emre-samuk;Initial Catalog=sinema_otomasyon_kopya;Integrated Security=True";
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle=new frmSeansEkle();
            ekle.ShowDialog();
            
        }
        int sayac = 0;
        private void FilmveSalonGetir(System.Windows.Forms.ComboBox combo, string sql1, string sql2)
        {
            using (SqlConnection baglanti = new SqlConnection(conString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sql1, baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    combo.Items.Add(reader[sql2].ToString());
                }
                baglanti.Close();
            }
        }
        private void FilmAfişi()
        {
            using (SqlConnection baglanti = new SqlConnection(conString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from film_bilgiler where filmadi= '"+comboFilmAdi.SelectedItem+"'",baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    pictureBox1.ImageLocation = reader["resimler"].ToString();
                }               
                baglanti.Close();
            }
        }
        private void Combo_Dolu_Koltuklar()
        {
            comboBiletIptal.Items.Clear();
            comboBiletIptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if(item is System.Windows.Forms.Button)
                {
                    if(item.BackColor==Color.Red)
                    {
                        comboBiletIptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void TekrarRenklendirme()
        {
            foreach(Control item in panel1.Controls)
            {
                if( item is System.Windows.Forms.Button)
                {
                    item.BackColor = Color.Cyan;
                }
            }
        }
        private void DoluKoltuklar()
        {
            using (SqlConnection baglanti = new SqlConnection(conString))
            { 
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from satis_bilgiler where filmadi='"+comboFilmAdi.SelectedItem+"' and salonadi='"+comboSalonAdi.SelectedItem+"' and tarih='"+comboFilmTarih.SelectedItem+"' and seans='"+comboFilmSeansi.SelectedItem+"' ",baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while(reader.Read())
                {
                    foreach (Control item in panel1.Controls)
                    {
                        if(item is System.Windows.Forms.Button)
                        {
                            if (reader["koltukno"].ToString()==item.Text)
                            {
                                item.BackColor = Color.Red;
                            }
                            
                        }
                    }
                }
                baglanti.Close() ;
            }
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            BoşKoltuk();
            FilmveSalonGetir(comboFilmAdi,"select *from film_bilgiler","filmadi");
            FilmveSalonGetir(comboSalonAdi, "select *from salon_bilgiler", "salonadi");
        }

        private void BoşKoltuk()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.BackColor = Color.Cyan;
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            if(b.BackColor==Color.Cyan)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.ShowDialog();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatışListele satis = new frmSatışListele();
            satis.ShowDialog();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            frmSeansGörüntüle görüntüle = new frmSeansGörüntüle();
            görüntüle.ShowDialog();
            
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansi.Items.Clear();
            comboFilmTarih.Items.Clear();
            comboSalonAdi.Text = "";
            comboFilmTarih.Text = "";
            comboFilmSeansi.Text = "";
            foreach (Control item in groupBox1.Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
            FilmAfişi();
            TekrarRenklendirme();
            Combo_Dolu_Koltuklar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        sinemaTableAdapters.Satis_BilgilerTableAdapter  satis= new sinemaTableAdapters.Satis_BilgilerTableAdapter();
        private void btnSatış_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text!="")
            {
                try
                {
                    satis.Satış_Yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarih.Text, comboFilmSeansi.Text, txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is System.Windows.Forms.TextBox) item.Text = "";
                    TekrarRenklendirme();
                    DoluKoltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata!!!"+hata.Message, "Uyarı");
                } 
            }
            else
            {
                MessageBox.Show("Koltuk Seçilmemiş!!!", "Uyarı");
            }
        }
        private void Film_Tarihi_Getir()
        {
            comboFilmTarih.Text = "";
            comboFilmSeansi.Text = "";
            comboFilmTarih.Items.Clear();
            comboFilmSeansi.Items.Clear();
            using (SqlConnection baglanti = new SqlConnection(conString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from seans_bilgiler where filmadi='"+comboFilmAdi.SelectedItem+"' and salonadi='"+comboSalonAdi.SelectedItem+"'",baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    comboFilmTarih.Items.Add(reader["tarih"].ToString());
                    
                }
                baglanti.Close();
            }

        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();   
        }
        private void Film_Seans_Getir()
        {
            comboFilmSeansi.Text = "";
            comboFilmSeansi.Items.Clear();
            using (SqlConnection baglanti = new SqlConnection(conString))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from seans_bilgiler where filmadi='" + comboFilmAdi.SelectedItem + "' and salonadi='" + comboSalonAdi.SelectedItem + "'", baglanti);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["tarih"].ToString())==DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        if (DateTime.Parse(reader["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                        {
                            comboFilmSeansi.Items.Add(reader["seans"].ToString());
                        }
                    }
                    else if (DateTime.Parse(reader["tarih"].ToString())>DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        comboFilmSeansi.Items.Add(reader["seans"].ToString());
                    }

                }
                baglanti.Close();
            }
        }
        
        private void comboFilmTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seans_Getir();
        }

        private void comboFilmSeansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TekrarRenklendirme();
            DoluKoltuklar();
            Combo_Dolu_Koltuklar();
        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            if (comboBiletIptal.Text!="")
            {
                try
                {
                    satis.Satış_İptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarih.Text, comboFilmSeansi.Text, comboBiletIptal.Text);
                    TekrarRenklendirme();
                    DoluKoltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata!!!"+hata.Message, "Uyarı");
                }
                
            }
            else
            {
                MessageBox.Show("Koltuk Seçimi Yapılmamış!!!", "Uyarı");
            }
        }
    }
}
