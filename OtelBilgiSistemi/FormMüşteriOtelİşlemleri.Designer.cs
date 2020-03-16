namespace OtelBilgiSistemi
{
    partial class FormMüşteriOtelİşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMüşteriOtelİşlemleri));
            this.lboxOteller = new System.Windows.Forms.ListBox();
            this.btnUygula = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFiltrele = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.cmbSıralama = new System.Windows.Forms.ComboBox();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYorum = new System.Windows.Forms.Button();
            this.btnPuan = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOtelİl = new System.Windows.Forms.Label();
            this.lblOtelİlçe = new System.Windows.Forms.Label();
            this.lblOtelAdres = new System.Windows.Forms.Label();
            this.lblOtelOdaSayısı = new System.Windows.Forms.Label();
            this.lblOtelPuan = new System.Windows.Forms.Label();
            this.lblOtelYıldız = new System.Windows.Forms.Label();
            this.lblOtelEposta = new System.Windows.Forms.Label();
            this.lblOtelTelefon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYorumlar = new System.Windows.Forms.TextBox();
            this.btnKaldır = new System.Windows.Forms.Button();
            this.lblSıralama = new System.Windows.Forms.Label();
            this.lblFiltreleme = new System.Windows.Forms.Label();
            this.lblOdaTipleri = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxOteller
            // 
            this.lboxOteller.FormattingEnabled = true;
            this.lboxOteller.Location = new System.Drawing.Point(192, 57);
            this.lboxOteller.Name = "lboxOteller";
            this.lboxOteller.Size = new System.Drawing.Size(236, 355);
            this.lboxOteller.Sorted = true;
            this.lboxOteller.TabIndex = 0;
            this.lboxOteller.SelectedIndexChanged += new System.EventHandler(this.LboxOteller_SelectedIndexChanged);
            // 
            // btnUygula
            // 
            this.btnUygula.Image = ((System.Drawing.Image)(resources.GetObject("btnUygula.Image")));
            this.btnUygula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUygula.Location = new System.Drawing.Point(15, 432);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(159, 32);
            this.btnUygula.TabIndex = 1;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(2, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 115);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(2, 163);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(184, 348);
            this.textBox2.TabIndex = 4;
            // 
            // lblFiltrele
            // 
            this.lblFiltrele.AutoSize = true;
            this.lblFiltrele.Location = new System.Drawing.Point(72, 60);
            this.lblFiltrele.Name = "lblFiltrele";
            this.lblFiltrele.Size = new System.Drawing.Size(51, 13);
            this.lblFiltrele.TabIndex = 5;
            this.lblFiltrele.Text = "Filtreleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sıralama";
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "İl",
            "İlçe",
            "En az puan",
            "En az yıldız"});
            this.cmbFiltre.Location = new System.Drawing.Point(15, 110);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(159, 21);
            this.cmbFiltre.TabIndex = 7;
            // 
            // cmbSıralama
            // 
            this.cmbSıralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSıralama.FormattingEnabled = true;
            this.cmbSıralama.Items.AddRange(new object[] {
            "Ad (A-Z)",
            "Ad (Z-A)",
            "Yıldız (Yüksekten Düşüğe)",
            "Puan (Yüksekten Düşüğe)"});
            this.cmbSıralama.Location = new System.Drawing.Point(15, 264);
            this.cmbSıralama.Name = "cmbSıralama";
            this.cmbSıralama.Size = new System.Drawing.Size(159, 21);
            this.cmbSıralama.TabIndex = 8;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(15, 137);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(159, 20);
            this.txtAranan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kıstas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kıstas";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(434, 57);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(184, 115);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "İşlemler";
            // 
            // btnYorum
            // 
            this.btnYorum.Image = ((System.Drawing.Image)(resources.GetObject("btnYorum.Image")));
            this.btnYorum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYorum.Location = new System.Drawing.Point(446, 84);
            this.btnYorum.Name = "btnYorum";
            this.btnYorum.Size = new System.Drawing.Size(161, 33);
            this.btnYorum.TabIndex = 14;
            this.btnYorum.Text = "Yorum yap";
            this.btnYorum.UseVisualStyleBackColor = true;
            this.btnYorum.Click += new System.EventHandler(this.btnYorum_Click);
            // 
            // btnPuan
            // 
            this.btnPuan.Image = ((System.Drawing.Image)(resources.GetObject("btnPuan.Image")));
            this.btnPuan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPuan.Location = new System.Drawing.Point(446, 123);
            this.btnPuan.Name = "btnPuan";
            this.btnPuan.Size = new System.Drawing.Size(161, 33);
            this.btnPuan.TabIndex = 17;
            this.btnPuan.Text = "Puan ver";
            this.btnPuan.UseVisualStyleBackColor = true;
            this.btnPuan.Click += new System.EventHandler(this.BtnPuan_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(434, 163);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(184, 348);
            this.textBox5.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Otel bilgileri";
            // 
            // lblOtelİl
            // 
            this.lblOtelİl.AutoSize = true;
            this.lblOtelİl.Location = new System.Drawing.Point(436, 202);
            this.lblOtelİl.Name = "lblOtelİl";
            this.lblOtelİl.Size = new System.Drawing.Size(15, 13);
            this.lblOtelİl.TabIndex = 20;
            this.lblOtelİl.Text = "İl:";
            // 
            // lblOtelİlçe
            // 
            this.lblOtelİlçe.AutoSize = true;
            this.lblOtelİlçe.Location = new System.Drawing.Point(518, 202);
            this.lblOtelİlçe.Name = "lblOtelİlçe";
            this.lblOtelİlçe.Size = new System.Drawing.Size(27, 13);
            this.lblOtelİlçe.TabIndex = 21;
            this.lblOtelİlçe.Text = "İlçe:";
            // 
            // lblOtelAdres
            // 
            this.lblOtelAdres.AutoSize = true;
            this.lblOtelAdres.Location = new System.Drawing.Point(436, 235);
            this.lblOtelAdres.Name = "lblOtelAdres";
            this.lblOtelAdres.Size = new System.Drawing.Size(37, 13);
            this.lblOtelAdres.TabIndex = 22;
            this.lblOtelAdres.Text = "Adres:";
            // 
            // lblOtelOdaSayısı
            // 
            this.lblOtelOdaSayısı.AutoSize = true;
            this.lblOtelOdaSayısı.Location = new System.Drawing.Point(436, 359);
            this.lblOtelOdaSayısı.Name = "lblOtelOdaSayısı";
            this.lblOtelOdaSayısı.Size = new System.Drawing.Size(58, 13);
            this.lblOtelOdaSayısı.TabIndex = 24;
            this.lblOtelOdaSayısı.Text = "Oda sayısı:";
            // 
            // lblOtelPuan
            // 
            this.lblOtelPuan.AutoSize = true;
            this.lblOtelPuan.Location = new System.Drawing.Point(520, 325);
            this.lblOtelPuan.Name = "lblOtelPuan";
            this.lblOtelPuan.Size = new System.Drawing.Size(35, 13);
            this.lblOtelPuan.TabIndex = 25;
            this.lblOtelPuan.Text = "Puan:";
            // 
            // lblOtelYıldız
            // 
            this.lblOtelYıldız.AutoSize = true;
            this.lblOtelYıldız.Location = new System.Drawing.Point(436, 325);
            this.lblOtelYıldız.Name = "lblOtelYıldız";
            this.lblOtelYıldız.Size = new System.Drawing.Size(34, 13);
            this.lblOtelYıldız.TabIndex = 26;
            this.lblOtelYıldız.Text = "Yıldız:";
            // 
            // lblOtelEposta
            // 
            this.lblOtelEposta.AutoSize = true;
            this.lblOtelEposta.Location = new System.Drawing.Point(436, 294);
            this.lblOtelEposta.Name = "lblOtelEposta";
            this.lblOtelEposta.Size = new System.Drawing.Size(43, 13);
            this.lblOtelEposta.TabIndex = 27;
            this.lblOtelEposta.Text = "Eposta:";
            // 
            // lblOtelTelefon
            // 
            this.lblOtelTelefon.AutoSize = true;
            this.lblOtelTelefon.Location = new System.Drawing.Point(436, 264);
            this.lblOtelTelefon.Name = "lblOtelTelefon";
            this.lblOtelTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblOtelTelefon.TabIndex = 28;
            this.lblOtelTelefon.Text = "Telefon:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 52);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 8);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 37);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(245, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 39);
            this.label9.TabIndex = 2;
            this.label9.Text = "Otel İşlemleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Yorumlar:";
            // 
            // txtYorumlar
            // 
            this.txtYorumlar.Location = new System.Drawing.Point(439, 405);
            this.txtYorumlar.Multiline = true;
            this.txtYorumlar.Name = "txtYorumlar";
            this.txtYorumlar.ReadOnly = true;
            this.txtYorumlar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtYorumlar.Size = new System.Drawing.Size(174, 96);
            this.txtYorumlar.TabIndex = 31;
            // 
            // btnKaldır
            // 
            this.btnKaldır.Image = ((System.Drawing.Image)(resources.GetObject("btnKaldır.Image")));
            this.btnKaldır.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaldır.Location = new System.Drawing.Point(15, 470);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(159, 35);
            this.btnKaldır.TabIndex = 32;
            this.btnKaldır.Text = "Filtreyi kaldır";
            this.btnKaldır.UseVisualStyleBackColor = true;
            this.btnKaldır.Click += new System.EventHandler(this.BtnKaldır_Click);
            // 
            // lblSıralama
            // 
            this.lblSıralama.AutoSize = true;
            this.lblSıralama.Location = new System.Drawing.Point(12, 346);
            this.lblSıralama.Name = "lblSıralama";
            this.lblSıralama.Size = new System.Drawing.Size(92, 13);
            this.lblSıralama.TabIndex = 33;
            this.lblSıralama.Text = "Sıralama: Ad (A-Z)";
            // 
            // lblFiltreleme
            // 
            this.lblFiltreleme.AutoSize = true;
            this.lblFiltreleme.Location = new System.Drawing.Point(12, 389);
            this.lblFiltreleme.Name = "lblFiltreleme";
            this.lblFiltreleme.Size = new System.Drawing.Size(76, 13);
            this.lblFiltreleme.TabIndex = 34;
            this.lblFiltreleme.Text = "Filtreleme: Yok";
            // 
            // lblOdaTipleri
            // 
            this.lblOdaTipleri.AutoSize = true;
            this.lblOdaTipleri.Location = new System.Drawing.Point(436, 346);
            this.lblOdaTipleri.Name = "lblOdaTipleri";
            this.lblOdaTipleri.Size = new System.Drawing.Size(57, 13);
            this.lblOdaTipleri.TabIndex = 35;
            this.lblOdaTipleri.Text = "Oda tipleri:";
            // 
            // FormMüşteriOtelİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(620, 513);
            this.Controls.Add(this.lblOdaTipleri);
            this.Controls.Add(this.lblFiltreleme);
            this.Controls.Add(this.lblSıralama);
            this.Controls.Add(this.btnKaldır);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.txtYorumlar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOtelTelefon);
            this.Controls.Add(this.lblOtelEposta);
            this.Controls.Add(this.lblOtelYıldız);
            this.Controls.Add(this.lblOtelPuan);
            this.Controls.Add(this.lblOtelOdaSayısı);
            this.Controls.Add(this.lblOtelAdres);
            this.Controls.Add(this.lblOtelİlçe);
            this.Controls.Add(this.lblOtelİl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnPuan);
            this.Controls.Add(this.btnYorum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.cmbSıralama);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFiltrele);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lboxOteller);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMüşteriOtelİşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMüşteriOtelİşlemleri";
            this.Load += new System.EventHandler(this.FormMüşteriOtelİşlemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxOteller;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFiltrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.ComboBox cmbSıralama;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYorum;
        private System.Windows.Forms.Button btnPuan;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOtelİl;
        private System.Windows.Forms.Label lblOtelİlçe;
        private System.Windows.Forms.Label lblOtelAdres;
        private System.Windows.Forms.Label lblOtelOdaSayısı;
        private System.Windows.Forms.Label lblOtelPuan;
        private System.Windows.Forms.Label lblOtelYıldız;
        private System.Windows.Forms.Label lblOtelEposta;
        private System.Windows.Forms.Label lblOtelTelefon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYorumlar;
        private System.Windows.Forms.Button btnKaldır;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblSıralama;
        private System.Windows.Forms.Label lblFiltreleme;
        private System.Windows.Forms.Label lblOdaTipleri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}