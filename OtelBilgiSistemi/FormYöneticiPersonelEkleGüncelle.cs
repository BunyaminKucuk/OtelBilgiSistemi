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
    public partial class FormYöneticiPersonelEkleGüncelle : Form
    {
        public string İstek;
       public Otel İşlemYapılacakOtel;
        DBİşlemleri db = DBİşlemleri.GetInstance();
        public Personel GüncellenecekPersonel;

        public FormYöneticiPersonelEkleGüncelle()
        {
            InitializeComponent();
        }

        private void FormYöneticiPersonelEkleGüncelle_Load(object sender, EventArgs e)
        {
            lblOtel.Text = İşlemYapılacakOtel.ad;

            if(İstek=="güncelle")
            {
                pboxArtı.Visible = false;
                pboxGüncelle.Visible = true;
                lblBaşlık.Text = "Personel Güncelle";
                btnEkleVeyaGüncelle.Text = "Güncelle";

                txtPersonelAd.ReadOnly = true;
                txtPersonelSoyad.ReadOnly = true;
                txtPersonelTC.ReadOnly = true;

                txtPersonelAd.Text = GüncellenecekPersonel.ad;
                txtPersonelSoyad.Text = GüncellenecekPersonel.soyad;
                txtPersonelEposta.Text = GüncellenecekPersonel.eposta;
                cmbDepartman.Text = GüncellenecekPersonel.departman;
                txtPersonelAdres.Text = GüncellenecekPersonel.adres;
                txtPersonelPozisyon.Text = GüncellenecekPersonel.pozisyon;
                txtPersonelPuan.Text = GüncellenecekPersonel.personelPuanı.ToString();
                txtPersonelTC.Text = GüncellenecekPersonel.tcKimlikNo;
                txtPersonelTelefon.Text = GüncellenecekPersonel.telefon;
            }
            
                
           

            
        }

        private void BtnEkleVeyaGüncelle_Click(object sender, EventArgs e)
        {
            if (İstek == "güncelle")
            {
                try
                {
                    İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad).telefon = txtPersonelTelefon.Text;
                    İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad).personelPuanı = Convert.ToInt16(txtPersonelPuan.Text);
                    İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad).eposta = txtPersonelEposta.Text;
                    İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad).pozisyon = txtPersonelPozisyon.Text;
                    İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad).departman = cmbDepartman.Text;
                    İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad).adres = txtPersonelAdres.Text;

                    db.PersonelGüncelle(İşlemYapılacakOtel.PersonelAra(GüncellenecekPersonel.ad));

                    MessageBox.Show("Personel güncellendi!");
                }
                catch
                {
                    MessageBox.Show("Bir hata oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {

                try
                {
                    Personel personel = new Personel();

                    personel.ad = txtPersonelAd.Text;
                    personel.soyad = txtPersonelSoyad.Text;
                    personel.tcKimlikNo = txtPersonelTC.Text;
                    personel.telefon = txtPersonelTelefon.Text;
                    personel.personelPuanı = Convert.ToInt16(txtPersonelPuan.Text);
                    personel.eposta = txtPersonelEposta.Text;
                    personel.pozisyon = txtPersonelPozisyon.Text;
                    personel.departman = cmbDepartman.Text;
                    personel.adres = txtPersonelAdres.Text;

                    İşlemYapılacakOtel.PersonelEkle(personel);
                    db.PersonelEkle(personel, İşlemYapılacakOtel.ad);

                    MessageBox.Show("Yeni personel eklendi!");
                }
                catch
                {
                    MessageBox.Show("Bir hata oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYöneticiPersonelİşlemleri formYöneticiPersonelİşlemleri = new FormYöneticiPersonelİşlemleri();
            formYöneticiPersonelİşlemleri.Otel = İşlemYapılacakOtel;
            formYöneticiPersonelİşlemleri.ShowDialog();
            this.Close();
        }
    }
}
