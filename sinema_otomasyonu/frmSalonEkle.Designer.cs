namespace sinema_otomasyonu
{
    partial class frmSalonEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalonEkle));
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalonAdi = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalonEkle.Location = new System.Drawing.Point(135, 80);
            this.btnSalonEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(65, 30);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "EKLE";
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salon Adı";
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Location = new System.Drawing.Point(113, 58);
            this.txtSalonAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSalonAdi.TabIndex = 2;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(243, 145);
            this.Controls.Add(this.txtSalonAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalonEkle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSalonEkle";
            this.Text = "SalonEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalonEkle_FormClosing);
            this.Load += new System.EventHandler(this.frmSalonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.ImageList ımageList1;
    }
}