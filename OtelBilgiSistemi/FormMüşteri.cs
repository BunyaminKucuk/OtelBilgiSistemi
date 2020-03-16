using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi
{
    public partial class FormMüşteri : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();
        public bool ilkAçılış = true;
        



        public FormMüşteri()
        {
            InitializeComponent();
        }

        private void FormMüşteri_Load(object sender, EventArgs e)
        {
            if(ilkAçılış) // Eğer ilk kez giriş yapılıyorsa db'den bilgileri çek
            {
                db.MüşteriOtelleriAl();
                db.YorumlarıAl();
                db.OtelAğacı.InOrder();                
            }
            lblHoşgeldin.Text += " " + db.OturumMüşteri.ad;
            txtOtelBilgileri.Text =db.OtelAğacı.DugumleriYazdir();
        }

        private void btnOtelİşlemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMüşteriOtelİşlemleri formMüşteriOtelİşlemleri = new FormMüşteriOtelİşlemleri();
            formMüşteriOtelİşlemleri.ShowDialog();
            this.Close();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            db.OtelAğacı.PreOrder();
            txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
        }

        private void BtnInOrder_Click(object sender, EventArgs e)
        {
            db.OtelAğacı.InOrder();
            txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
        }


        private void BtnAğaçBilgileri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eleman sayısı: " + db.OtelAğacı.DugumSayisiBul().ToString()+Environment.NewLine+"Derinlik Sayısı: " + db.OtelAğacı.DerinlikBul());
        }

        private void BtnPostOrder_Click_1(object sender, EventArgs e)
        {
            db.OtelAğacı.PostOrder();
            txtOtelBilgileri.Text = db.OtelAğacı.DugumleriYazdir();
        }
    }
}
