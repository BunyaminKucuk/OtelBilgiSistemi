namespace OtelBilgiSistemi
{
    partial class FormYönetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYönetici));
            this.btnOtelEkle = new System.Windows.Forms.Button();
            this.btnPersonelİşlemleri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOdaTipleri = new System.Windows.Forms.Label();
            this.lblFiltreleme = new System.Windows.Forms.Label();
            this.lblSıralama = new System.Windows.Forms.Label();
            this.btnKaldır = new System.Windows.Forms.Button();
            this.btnUygula = new System.Windows.Forms.Button();
            this.txtYorumlar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOtelTelefon = new System.Windows.Forms.Label();
            this.lblOtelEposta = new System.Windows.Forms.Label();
            this.lblOtelYıldız = new System.Windows.Forms.Label();
            this.lblOtelPuan = new System.Windows.Forms.Label();
            this.lblOtelOdaSayısı = new System.Windows.Forms.Label();
            this.lblOtelAdres = new System.Windows.Forms.Label();
            this.lblOtelİlçe = new System.Windows.Forms.Label();
            this.lblOtelİl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.lblFiltrele = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lboxOteller = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtelEkle
            // 
            this.btnOtelEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOtelEkle.Image")));
            this.btnOtelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOtelEkle.Location = new System.Drawing.Point(235, 470);
            this.btnOtelEkle.Name = "btnOtelEkle";
            this.btnOtelEkle.Size = new System.Drawing.Size(150, 27);
            this.btnOtelEkle.TabIndex = 0;
            this.btnOtelEkle.Text = "Yeni otel ekle";
            this.btnOtelEkle.UseVisualStyleBackColor = true;
            this.btnOtelEkle.Click += new System.EventHandler(this.BtnOtelEkle_Click);
            // 
            // btnPersonelİşlemleri
            // 
            this.btnPersonelİşlemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelİşlemleri.Image")));
            this.btnPersonelİşlemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelİşlemleri.Location = new System.Drawing.Point(235, 441);
            this.btnPersonelİşlemleri.Name = "btnPersonelİşlemleri";
            this.btnPersonelİşlemleri.Size = new System.Drawing.Size(150, 23);
            this.btnPersonelİşlemleri.TabIndex = 1;
            this.btnPersonelİşlemleri.Text = "Personel İşlemleri";
            this.btnPersonelİşlemleri.UseVisualStyleBackColor = true;
            this.btnPersonelİşlemleri.Click += new System.EventHandler(this.BtnPersonelİşlemleri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 53);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // lblOdaTipleri
            // 
            this.lblOdaTipleri.AutoSize = true;
            this.lblOdaTipleri.Location = new System.Drawing.Point(435, 242);
            this.lblOdaTipleri.Name = "lblOdaTipleri";
            this.lblOdaTipleri.Size = new System.Drawing.Size(57, 13);
            this.lblOdaTipleri.TabIndex = 66;
            this.lblOdaTipleri.Text = "Oda tipleri:";
            // 
            // lblFiltreleme
            // 
            this.lblFiltreleme.AutoSize = true;
            this.lblFiltreleme.Location = new System.Drawing.Point(10, 285);
            this.lblFiltreleme.Name = "lblFiltreleme";
            this.lblFiltreleme.Size = new System.Drawing.Size(76, 13);
            this.lblFiltreleme.TabIndex = 65;
            this.lblFiltreleme.Text = "Filtreleme: Yok";
            // 
            // lblSıralama
            // 
            this.lblSıralama.AutoSize = true;
            this.lblSıralama.Location = new System.Drawing.Point(10, 242);
            this.lblSıralama.Name = "lblSıralama";
            this.lblSıralama.Size = new System.Drawing.Size(92, 13);
            this.lblSıralama.TabIndex = 64;
            this.lblSıralama.Text = "Sıralama: Ad (A-Z)";
            // 
            // btnKaldır
            // 
            this.btnKaldır.Image = ((System.Drawing.Image)(resources.GetObject("btnKaldır.Image")));
            this.btnKaldır.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaldır.Location = new System.Drawing.Point(12, 362);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(159, 35);
            this.btnKaldır.TabIndex = 63;
            this.btnKaldır.Text = "Filtreyi kaldır";
            this.btnKaldır.UseVisualStyleBackColor = true;
            this.btnKaldır.Click += new System.EventHandler(this.BtnKaldır_Click);
            // 
            // btnUygula
            // 
            this.btnUygula.Image = ((System.Drawing.Image)(resources.GetObject("btnUygula.Image")));
            this.btnUygula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUygula.Location = new System.Drawing.Point(13, 321);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(159, 35);
            this.btnUygula.TabIndex = 37;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.BtnUygula_Click);
            // 
            // txtYorumlar
            // 
            this.txtYorumlar.Location = new System.Drawing.Point(438, 301);
            this.txtYorumlar.Multiline = true;
            this.txtYorumlar.Name = "txtYorumlar";
            this.txtYorumlar.ReadOnly = true;
            this.txtYorumlar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtYorumlar.Size = new System.Drawing.Size(174, 96);
            this.txtYorumlar.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Yorumlar:";
            // 
            // lblOtelTelefon
            // 
            this.lblOtelTelefon.AutoSize = true;
            this.lblOtelTelefon.Location = new System.Drawing.Point(435, 160);
            this.lblOtelTelefon.Name = "lblOtelTelefon";
            this.lblOtelTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblOtelTelefon.TabIndex = 60;
            this.lblOtelTelefon.Text = "Telefon:";
            // 
            // lblOtelEposta
            // 
            this.lblOtelEposta.AutoSize = true;
            this.lblOtelEposta.Location = new System.Drawing.Point(435, 190);
            this.lblOtelEposta.Name = "lblOtelEposta";
            this.lblOtelEposta.Size = new System.Drawing.Size(43, 13);
            this.lblOtelEposta.TabIndex = 59;
            this.lblOtelEposta.Text = "Eposta:";
            // 
            // lblOtelYıldız
            // 
            this.lblOtelYıldız.AutoSize = true;
            this.lblOtelYıldız.Location = new System.Drawing.Point(435, 221);
            this.lblOtelYıldız.Name = "lblOtelYıldız";
            this.lblOtelYıldız.Size = new System.Drawing.Size(34, 13);
            this.lblOtelYıldız.TabIndex = 58;
            this.lblOtelYıldız.Text = "Yıldız:";
            // 
            // lblOtelPuan
            // 
            this.lblOtelPuan.AutoSize = true;
            this.lblOtelPuan.Location = new System.Drawing.Point(519, 221);
            this.lblOtelPuan.Name = "lblOtelPuan";
            this.lblOtelPuan.Size = new System.Drawing.Size(35, 13);
            this.lblOtelPuan.TabIndex = 57;
            this.lblOtelPuan.Text = "Puan:";
            // 
            // lblOtelOdaSayısı
            // 
            this.lblOtelOdaSayısı.AutoSize = true;
            this.lblOtelOdaSayısı.Location = new System.Drawing.Point(435, 255);
            this.lblOtelOdaSayısı.Name = "lblOtelOdaSayısı";
            this.lblOtelOdaSayısı.Size = new System.Drawing.Size(58, 13);
            this.lblOtelOdaSayısı.TabIndex = 56;
            this.lblOtelOdaSayısı.Text = "Oda sayısı:";
            // 
            // lblOtelAdres
            // 
            this.lblOtelAdres.AutoSize = true;
            this.lblOtelAdres.Location = new System.Drawing.Point(435, 131);
            this.lblOtelAdres.Name = "lblOtelAdres";
            this.lblOtelAdres.Size = new System.Drawing.Size(37, 13);
            this.lblOtelAdres.TabIndex = 55;
            this.lblOtelAdres.Text = "Adres:";
            // 
            // lblOtelİlçe
            // 
            this.lblOtelİlçe.AutoSize = true;
            this.lblOtelİlçe.Location = new System.Drawing.Point(517, 104);
            this.lblOtelİlçe.Name = "lblOtelİlçe";
            this.lblOtelİlçe.Size = new System.Drawing.Size(27, 13);
            this.lblOtelİlçe.TabIndex = 54;
            this.lblOtelİlçe.Text = "İlçe:";
            // 
            // lblOtelİl
            // 
            this.lblOtelİl.AutoSize = true;
            this.lblOtelİl.Location = new System.Drawing.Point(435, 104);
            this.lblOtelİl.Name = "lblOtelİl";
            this.lblOtelİl.Size = new System.Drawing.Size(15, 13);
            this.lblOtelİl.TabIndex = 53;
            this.lblOtelİl.Text = "İl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Otel bilgileri";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(433, 53);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(184, 355);
            this.textBox5.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "İşlemler";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(0, 405);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(617, 103);
            this.textBox4.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Kıstas";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(12, 164);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(159, 20);
            this.txtAranan.TabIndex = 44;
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "İl",
            "İlçe"});
            this.cmbFiltre.Location = new System.Drawing.Point(12, 137);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(159, 21);
            this.cmbFiltre.TabIndex = 42;
            // 
            // lblFiltrele
            // 
            this.lblFiltrele.AutoSize = true;
            this.lblFiltrele.Location = new System.Drawing.Point(74, 71);
            this.lblFiltrele.Name = "lblFiltrele";
            this.lblFiltrele.Size = new System.Drawing.Size(51, 13);
            this.lblFiltrele.TabIndex = 40;
            this.lblFiltrele.Text = "Filtreleme";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(0, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(192, 355);
            this.textBox2.TabIndex = 39;
            // 
            // lboxOteller
            // 
            this.lboxOteller.FormattingEnabled = true;
            this.lboxOteller.Location = new System.Drawing.Point(190, 53);
            this.lboxOteller.Name = "lboxOteller";
            this.lboxOteller.Size = new System.Drawing.Size(242, 355);
            this.lboxOteller.Sorted = true;
            this.lboxOteller.TabIndex = 36;
            this.lboxOteller.SelectedIndexChanged += new System.EventHandler(this.LboxOteller_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(393, 441);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 67;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.Image")));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.Location = new System.Drawing.Point(129, 441);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGüncelle.TabIndex = 68;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // FormYönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 511);
            this.Controls.Add(this.lboxOteller);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblOdaTipleri);
            this.Controls.Add(this.lblFiltreleme);
            this.Controls.Add(this.lblSıralama);
            this.Controls.Add(this.btnKaldır);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.txtYorumlar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOtelTelefon);
            this.Controls.Add(this.lblOtelEposta);
            this.Controls.Add(this.lblOtelYıldız);
            this.Controls.Add(this.lblOtelPuan);
            this.Controls.Add(this.lblOtelOdaSayısı);
            this.Controls.Add(this.lblOtelAdres);
            this.Controls.Add(this.lblOtelİlçe);
            this.Controls.Add(this.lblOtelİl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.lblFiltrele);
            this.Controls.Add(this.btnPersonelİşlemleri);
            this.Controls.Add(this.btnOtelEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Name = "FormYönetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYönetici";
            this.Load += new System.EventHandler(this.FormYönetici_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtelEkle;
        private System.Windows.Forms.Button btnPersonelİşlemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOdaTipleri;
        private System.Windows.Forms.Label lblFiltreleme;
        private System.Windows.Forms.Label lblSıralama;
        private System.Windows.Forms.Button btnKaldır;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.TextBox txtYorumlar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOtelTelefon;
        private System.Windows.Forms.Label lblOtelEposta;
        private System.Windows.Forms.Label lblOtelYıldız;
        private System.Windows.Forms.Label lblOtelPuan;
        private System.Windows.Forms.Label lblOtelOdaSayısı;
        private System.Windows.Forms.Label lblOtelAdres;
        private System.Windows.Forms.Label lblOtelİlçe;
        private System.Windows.Forms.Label lblOtelİl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label lblFiltrele;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lboxOteller;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}