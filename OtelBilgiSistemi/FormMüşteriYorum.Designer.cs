namespace OtelBilgiSistemi
{
    partial class FormMüşteriYorum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMüşteriYorum));
            this.lblYorum = new System.Windows.Forms.Label();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGönder = new System.Windows.Forms.Button();
            this.lblOtelAdı = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYorum
            // 
            this.lblYorum.AutoSize = true;
            this.lblYorum.Location = new System.Drawing.Point(57, 100);
            this.lblYorum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYorum.Name = "lblYorum";
            this.lblYorum.Size = new System.Drawing.Size(63, 13);
            this.lblYorum.TabIndex = 3;
            this.lblYorum.Text = "Yorumunuz:";
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(60, 115);
            this.txtYorum.Margin = new System.Windows.Forms.Padding(2);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(203, 76);
            this.txtYorum.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 47);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(84, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 39);
            this.label9.TabIndex = 6;
            this.label9.Text = "Yorum Yap";
            // 
            // btnGönder
            // 
            this.btnGönder.Location = new System.Drawing.Point(182, 203);
            this.btnGönder.Margin = new System.Windows.Forms.Padding(2);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(79, 21);
            this.btnGönder.TabIndex = 6;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = true;
            this.btnGönder.Click += new System.EventHandler(this.BtnGönder_Click);
            // 
            // lblOtelAdı
            // 
            this.lblOtelAdı.AutoSize = true;
            this.lblOtelAdı.Location = new System.Drawing.Point(80, 67);
            this.lblOtelAdı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtelAdı.Name = "lblOtelAdı";
            this.lblOtelAdı.Size = new System.Drawing.Size(47, 13);
            this.lblOtelAdı.TabIndex = 7;
            this.lblOtelAdı.Text = "Otel Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormMüşteriYorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 246);
            this.Controls.Add(this.lblOtelAdı);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.lblYorum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMüşteriYorum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMüşteriYorum";
            this.Load += new System.EventHandler(this.FormMüşteriYorum_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblYorum;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGönder;
        public System.Windows.Forms.Label lblOtelAdı;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}