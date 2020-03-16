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
    public partial class FormGiriş : Form
    {

        DBİşlemleri dB = DBİşlemleri.GetInstance();
        public FormGiriş()
        {
            InitializeComponent();
        }


        private void btnGiriş_Click(object sender, EventArgs e)
        {

           if(dB.MüşteriOturumu(txtKullanıcıAdı.Text, txtŞifre.Text)==true)  //Giriş yapmaya çalışan kişi müşteri ise
            {
                if (dB.OturumVer(txtKullanıcıAdı.Text, txtŞifre.Text) == false) //Böyle bir kullanıcı yoksa
                {
                    MessageBox.Show("Kullanıcı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
                FormMüşteri formMüşteri = new FormMüşteri();
                formMüşteri.ShowDialog();
                this.Close();

            }
            else
            {
                if (dB.OturumVer(txtKullanıcıAdı.Text, txtŞifre.Text) == false) //Böyle bir kullanıcı yoksa
                {
                    MessageBox.Show("Kullanıcı Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
                FormYönetici formYönetici = new FormYönetici();
                formYönetici.ShowDialog();
                this.Close();
            }
        }

 
    }
}
