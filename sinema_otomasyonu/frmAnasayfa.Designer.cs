namespace sinema_otomasyonu
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSatış = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.comboUcret = new System.Windows.Forms.ComboBox();
            this.comboFilmSeansi = new System.Windows.Forms.ComboBox();
            this.comboFilmTarih = new System.Windows.Forms.ComboBox();
            this.comboSalonAdi = new System.Windows.Forms.ComboBox();
            this.comboFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBiletİptal = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBiletIptal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnSatış);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtKoltukNo);
            this.groupBox1.Controls.Add(this.comboUcret);
            this.groupBox1.Controls.Add(this.comboFilmSeansi);
            this.groupBox1.Controls.Add(this.comboFilmTarih);
            this.groupBox1.Controls.Add(this.comboSalonAdi);
            this.groupBox1.Controls.Add(this.comboFilmAdi);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(655, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(217, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Satış";
            // 
            // btnSatış
            // 
            this.btnSatış.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSatış.Location = new System.Drawing.Point(112, 215);
            this.btnSatış.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatış.Name = "btnSatış";
            this.btnSatış.Size = new System.Drawing.Size(92, 27);
            this.btnSatış.TabIndex = 16;
            this.btnSatış.Text = "Satış";
            this.btnSatış.UseVisualStyleBackColor = true;
            this.btnSatış.Click += new System.EventHandler(this.btnSatış_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(11, 193);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Ücret";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(11, 170);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Soyad ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(11, 149);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Ad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(11, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Koltuk No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(11, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Film Seansı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(11, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Film Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Salon Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Film Adı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 170);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(92, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 149);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(92, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Enabled = false;
            this.txtKoltukNo.Location = new System.Drawing.Point(112, 126);
            this.txtKoltukNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(92, 20);
            this.txtKoltukNo.TabIndex = 5;
            // 
            // comboUcret
            // 
            this.comboUcret.FormattingEnabled = true;
            this.comboUcret.Location = new System.Drawing.Point(112, 193);
            this.comboUcret.Margin = new System.Windows.Forms.Padding(2);
            this.comboUcret.Name = "comboUcret";
            this.comboUcret.Size = new System.Drawing.Size(92, 21);
            this.comboUcret.Sorted = true;
            this.comboUcret.TabIndex = 4;
            // 
            // comboFilmSeansi
            // 
            this.comboFilmSeansi.FormattingEnabled = true;
            this.comboFilmSeansi.Location = new System.Drawing.Point(112, 102);
            this.comboFilmSeansi.Margin = new System.Windows.Forms.Padding(2);
            this.comboFilmSeansi.Name = "comboFilmSeansi";
            this.comboFilmSeansi.Size = new System.Drawing.Size(92, 21);
            this.comboFilmSeansi.Sorted = true;
            this.comboFilmSeansi.TabIndex = 3;
            this.comboFilmSeansi.SelectedIndexChanged += new System.EventHandler(this.comboFilmSeansi_SelectedIndexChanged);
            // 
            // comboFilmTarih
            // 
            this.comboFilmTarih.FormattingEnabled = true;
            this.comboFilmTarih.Location = new System.Drawing.Point(112, 77);
            this.comboFilmTarih.Margin = new System.Windows.Forms.Padding(2);
            this.comboFilmTarih.Name = "comboFilmTarih";
            this.comboFilmTarih.Size = new System.Drawing.Size(92, 21);
            this.comboFilmTarih.Sorted = true;
            this.comboFilmTarih.TabIndex = 2;
            this.comboFilmTarih.SelectedIndexChanged += new System.EventHandler(this.comboFilmTarih_SelectedIndexChanged);
            // 
            // comboSalonAdi
            // 
            this.comboSalonAdi.FormattingEnabled = true;
            this.comboSalonAdi.Location = new System.Drawing.Point(112, 53);
            this.comboSalonAdi.Margin = new System.Windows.Forms.Padding(2);
            this.comboSalonAdi.Name = "comboSalonAdi";
            this.comboSalonAdi.Size = new System.Drawing.Size(92, 21);
            this.comboSalonAdi.Sorted = true;
            this.comboSalonAdi.TabIndex = 1;
            this.comboSalonAdi.SelectedIndexChanged += new System.EventHandler(this.comboSalonAdi_SelectedIndexChanged);
            // 
            // comboFilmAdi
            // 
            this.comboFilmAdi.FormattingEnabled = true;
            this.comboFilmAdi.Location = new System.Drawing.Point(112, 28);
            this.comboFilmAdi.Margin = new System.Windows.Forms.Padding(2);
            this.comboFilmAdi.Name = "comboFilmAdi";
            this.comboFilmAdi.Size = new System.Drawing.Size(92, 21);
            this.comboFilmAdi.Sorted = true;
            this.comboFilmAdi.TabIndex = 0;
            this.comboFilmAdi.SelectedIndexChanged += new System.EventHandler(this.comboFilmAdi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnBiletİptal);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.comboBiletIptal);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(655, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(217, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet İptal";
            // 
            // btnBiletİptal
            // 
            this.btnBiletİptal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBiletİptal.Location = new System.Drawing.Point(112, 82);
            this.btnBiletİptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBiletİptal.Name = "btnBiletİptal";
            this.btnBiletİptal.Size = new System.Drawing.Size(92, 26);
            this.btnBiletİptal.TabIndex = 17;
            this.btnBiletİptal.Text = "Bilet İptal";
            this.btnBiletİptal.UseVisualStyleBackColor = true;
            this.btnBiletİptal.Click += new System.EventHandler(this.btnBiletİptal_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(11, 54);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Koltuk No";
            // 
            // comboBiletIptal
            // 
            this.comboBiletIptal.FormattingEnabled = true;
            this.comboBiletIptal.Location = new System.Drawing.Point(112, 54);
            this.comboBiletIptal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBiletIptal.Name = "comboBiletIptal";
            this.comboBiletIptal.Size = new System.Drawing.Size(92, 21);
            this.comboBiletIptal.Sorted = true;
            this.comboBiletIptal.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 290);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(54, 461);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(333, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(225, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boş ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(466, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Film Afişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(4, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(4, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(3, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "H";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(3, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "N";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(4, 392);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "E";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.btnÇıkış);
            this.groupBox4.Controls.Add(this.btnSeansListele);
            this.groupBox4.Controls.Add(this.btnSeansEkle);
            this.groupBox4.Controls.Add(this.btnFilmEkle);
            this.groupBox4.Controls.Add(this.btnSalonEkle);
            this.groupBox4.Location = new System.Drawing.Point(54, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(579, 115);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(378, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Satışlar";
            // 
            // button1
            // 
            this.button1.ImageKey = "indirsatış.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(361, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 52);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "listeleme.png");
            this.ımageList1.Images.SetKeyName(1, "çıkış.png");
            this.ımageList1.Images.SetKeyName(2, "list.png");
            this.ımageList1.Images.SetKeyName(3, "images.png");
            this.ımageList1.Images.SetKeyName(4, "images (1).png");
            this.ımageList1.Images.SetKeyName(5, "kurtlar vadisi.jpeg");
            this.ımageList1.Images.SetKeyName(6, "salonindir.jpeg");
            this.ımageList1.Images.SetKeyName(7, "abooindir.png");
            this.ımageList1.Images.SetKeyName(8, "indirsatış.jpg");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label25.Location = new System.Drawing.Point(469, 88);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Çıkış";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label24.Location = new System.Drawing.Point(281, 88);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Seans Listele";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label23.Location = new System.Drawing.Point(203, 88);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Seans ekle";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label22.Location = new System.Drawing.Point(133, 88);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Film Ekle";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label21.Location = new System.Drawing.Point(56, 88);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Salon Ekle";
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.ImageIndex = 1;
            this.btnÇıkış.ImageList = this.ımageList1;
            this.btnÇıkış.Location = new System.Drawing.Point(443, 33);
            this.btnÇıkış.Margin = new System.Windows.Forms.Padding(2);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnÇıkış.Size = new System.Drawing.Size(80, 52);
            this.btnÇıkış.TabIndex = 4;
            this.btnÇıkış.UseVisualStyleBackColor = true;
            this.btnÇıkış.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.ImageKey = "images.png";
            this.btnSeansListele.ImageList = this.ımageList1;
            this.btnSeansListele.Location = new System.Drawing.Point(271, 33);
            this.btnSeansListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(85, 52);
            this.btnSeansListele.TabIndex = 3;
            this.btnSeansListele.UseVisualStyleBackColor = true;
            this.btnSeansListele.Click += new System.EventHandler(this.btnSeansListele_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.ImageKey = "images (1).png";
            this.btnSeansEkle.ImageList = this.ımageList1;
            this.btnSeansEkle.Location = new System.Drawing.Point(193, 33);
            this.btnSeansEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(74, 52);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.ImageKey = "kurtlar vadisi.jpeg";
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(119, 33);
            this.btnFilmEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(69, 52);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.ImageKey = "abooindir.png";
            this.btnSalonEkle.ImageList = this.ımageList1;
            this.btnSalonEkle.Location = new System.Drawing.Point(41, 33);
            this.btnSalonEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(74, 52);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 556);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.ComboBox comboUcret;
        private System.Windows.Forms.ComboBox comboFilmSeansi;
        private System.Windows.Forms.ComboBox comboFilmTarih;
        private System.Windows.Forms.ComboBox comboSalonAdi;
        private System.Windows.Forms.ComboBox comboFilmAdi;
        private System.Windows.Forms.Button btnSatış;
        private System.Windows.Forms.Button btnBiletİptal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBiletIptal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

