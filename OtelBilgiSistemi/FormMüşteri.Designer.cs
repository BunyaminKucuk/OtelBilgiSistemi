namespace OtelBilgiSistemi
{
    partial class FormMüşteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMüşteri));
            this.lblHoşgeldin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOtelİşlemleri = new System.Windows.Forms.Button();
            this.txtOtelBilgileri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnPreOrder = new System.Windows.Forms.Button();
            this.btnAğaçBilgileri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoşgeldin
            // 
            this.lblHoşgeldin.AutoSize = true;
            this.lblHoşgeldin.Location = new System.Drawing.Point(325, 411);
            this.lblHoşgeldin.Name = "lblHoşgeldin";
            this.lblHoşgeldin.Size = new System.Drawing.Size(54, 13);
            this.lblHoşgeldin.TabIndex = 8;
            this.lblHoşgeldin.Text = "Hoşgeldin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 53);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(311, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri Paneli";
            // 
            // btnOtelİşlemleri
            // 
            this.btnOtelİşlemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnOtelİşlemleri.Image")));
            this.btnOtelİşlemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOtelİşlemleri.Location = new System.Drawing.Point(317, 366);
            this.btnOtelİşlemleri.Name = "btnOtelİşlemleri";
            this.btnOtelİşlemleri.Size = new System.Drawing.Size(160, 29);
            this.btnOtelİşlemleri.TabIndex = 9;
            this.btnOtelİşlemleri.Text = "Otel İşlemleri";
            this.btnOtelİşlemleri.UseVisualStyleBackColor = true;
            this.btnOtelİşlemleri.Click += new System.EventHandler(this.btnOtelİşlemleri_Click);
            // 
            // txtOtelBilgileri
            // 
            this.txtOtelBilgileri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtOtelBilgileri.Location = new System.Drawing.Point(12, 112);
            this.txtOtelBilgileri.Multiline = true;
            this.txtOtelBilgileri.Name = "txtOtelBilgileri";
            this.txtOtelBilgileri.ReadOnly = true;
            this.txtOtelBilgileri.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOtelBilgileri.Size = new System.Drawing.Size(750, 196);
            this.txtOtelBilgileri.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yıldız";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Puan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(686, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Oda sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Eposta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "İlçe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Adres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "İl";
            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(120, 314);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(98, 23);
            this.btnInOrder.TabIndex = 21;
            this.btnInOrder.Text = "InOrder";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.BtnInOrder_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.Location = new System.Drawing.Point(224, 314);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(98, 23);
            this.btnPostOrder.TabIndex = 22;
            this.btnPostOrder.Text = "PostOrder";
            this.btnPostOrder.UseVisualStyleBackColor = true;
            this.btnPostOrder.Click += new System.EventHandler(this.BtnPostOrder_Click_1);
            // 
            // btnPreOrder
            // 
            this.btnPreOrder.Location = new System.Drawing.Point(12, 314);
            this.btnPreOrder.Name = "btnPreOrder";
            this.btnPreOrder.Size = new System.Drawing.Size(98, 23);
            this.btnPreOrder.TabIndex = 23;
            this.btnPreOrder.Text = "PreOrder";
            this.btnPreOrder.UseVisualStyleBackColor = true;
            this.btnPreOrder.Click += new System.EventHandler(this.btnPreOrder_Click);
            // 
            // btnAğaçBilgileri
            // 
            this.btnAğaçBilgileri.Location = new System.Drawing.Point(595, 314);
            this.btnAğaçBilgileri.Name = "btnAğaçBilgileri";
            this.btnAğaçBilgileri.Size = new System.Drawing.Size(167, 23);
            this.btnAğaçBilgileri.TabIndex = 24;
            this.btnAğaçBilgileri.Text = "Ağaç derinliği ve eleman sayısı";
            this.btnAğaçBilgileri.UseVisualStyleBackColor = true;
            this.btnAğaçBilgileri.Click += new System.EventHandler(this.BtnAğaçBilgileri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Oda tipleri";
            // 
            // FormMüşteri
            // 
            this.AcceptButton = this.btnOtelİşlemleri;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAğaçBilgileri);
            this.Controls.Add(this.btnPreOrder);
            this.Controls.Add(this.btnPostOrder);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOtelBilgileri);
            this.Controls.Add(this.btnOtelİşlemleri);
            this.Controls.Add(this.lblHoşgeldin);
            this.Controls.Add(this.panel1);
            this.Name = "FormMüşteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMüşteri";
            this.Load += new System.EventHandler(this.FormMüşteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoşgeldin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtelİşlemleri;
        private System.Windows.Forms.TextBox txtOtelBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnPreOrder;
        private System.Windows.Forms.Button btnAğaçBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}