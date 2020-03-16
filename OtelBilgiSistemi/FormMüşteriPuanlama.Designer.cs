namespace OtelBilgiSistemi
{
    partial class FormMüşteriPuanlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMüşteriPuanlama));
            this.lblAd = new System.Windows.Forms.Label();
            this.cmbPuan = new System.Windows.Forms.ComboBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPuan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(71, 73);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(47, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Otel Adı:";
            // 
            // cmbPuan
            // 
            this.cmbPuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuan.FormattingEnabled = true;
            this.cmbPuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPuan.Location = new System.Drawing.Point(140, 103);
            this.cmbPuan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPuan.Name = "cmbPuan";
            this.cmbPuan.Size = new System.Drawing.Size(82, 21);
            this.cmbPuan.TabIndex = 1;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(71, 108);
            this.lblPuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(50, 13);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "Puanınız:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 45);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(106, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 39);
            this.label9.TabIndex = 6;
            this.label9.Text = "Puanla";
            // 
            // btnPuan
            // 
            this.btnPuan.Location = new System.Drawing.Point(140, 151);
            this.btnPuan.Margin = new System.Windows.Forms.Padding(2);
            this.btnPuan.Name = "btnPuan";
            this.btnPuan.Size = new System.Drawing.Size(81, 21);
            this.btnPuan.TabIndex = 7;
            this.btnPuan.Text = "Gönder";
            this.btnPuan.UseVisualStyleBackColor = true;
            this.btnPuan.Click += new System.EventHandler(this.BtnPuan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormMüşteriPuanlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 206);
            this.Controls.Add(this.btnPuan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.cmbPuan);
            this.Controls.Add(this.lblAd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMüşteriPuanlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPuanlama";
            this.Load += new System.EventHandler(this.FormMüşteriPuanlama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ComboBox cmbPuan;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPuan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}