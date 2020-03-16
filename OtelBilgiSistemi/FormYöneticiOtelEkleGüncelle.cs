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
    public partial class FormYöneticiOtelEkleGüncelle : Form
    {
        public string İstek;
        DBİşlemleri db = DBİşlemleri.GetInstance();
        public Otel GüncellenecekOtel;


        public FormYöneticiOtelEkleGüncelle()
        {
            InitializeComponent();
        }

        private void btnOtelEkle_Click(object sender, EventArgs e)
        {
            if(İstek=="güncelle")
            {
                try
                {
                    GüncellenecekOtel.telefon = txtOtelTelefon.Text;
                    GüncellenecekOtel.eposta = txtOtelEposta.Text;
                    GüncellenecekOtel.yıldızSayısı = Convert.ToInt16(txtOtelYıldızSayısı.Text);
                    GüncellenecekOtel.odaSayısı = Convert.ToInt32(txtOtelOdaSayısı.Text);
                    GüncellenecekOtel.odaTipleri = txtOdaTipleri.Text;
                    GüncellenecekOtel.adres = txtOtelAdres.Text;

                    db.OtelAğacı.Ara(txtOtelAd.Text).otel = GüncellenecekOtel;
                    db.OtelGüncelle(GüncellenecekOtel);

                    MessageBox.Show("Otel Güncellendi!");
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
                    Otel Otel = new Otel();

                    Otel.ad = txtOtelAd.Text;
                    Otel.il = txtOtelİl.Text;
                    Otel.ilçe = txtOtelİlçe.Text;
                    Otel.telefon = txtOtelTelefon.Text;
                    Otel.eposta = txtOtelEposta.Text;
                    Otel.adres = txtOtelAdres.Text;
                    Otel.odaTipleri = txtOdaTipleri.Text;
                    Otel.yıldızSayısı = Convert.ToInt32(txtOtelYıldızSayısı.Text);
                    Otel.odaSayısı = Convert.ToInt32(txtOtelOdaSayısı.Text);

                    db.OtelEkle(Otel);
                    db.AğacaEkle(Otel);


                    MessageBox.Show("Yeni otel Eklendi!");
                }
                catch
                {
                    MessageBox.Show("Bir hata oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }                           
        }

        private void FormYöneticiOtelEkleGüncelle_Load(object sender, EventArgs e)
        {
            if(İstek=="güncelle")
            {        
                pboxArtı.Visible = false;
                pboxGüncelle.Visible = true;
                lblBaşlık.Text = "Otel Güncelle";
                btnEkleVeyaGüncelle.Text = "Güncelle";
                txtOtelAd.ReadOnly = true;
                txtOtelİl.ReadOnly = true;
                txtOtelİlçe.ReadOnly = true;

                txtOtelAd.Text = GüncellenecekOtel.ad;
                txtOtelİl.Text = GüncellenecekOtel.il;
                txtOtelİlçe.Text = GüncellenecekOtel.ilçe;
                txtOtelAdres.Text = GüncellenecekOtel.adres;
                txtOtelEposta.Text = GüncellenecekOtel.eposta;
                txtOtelTelefon.Text = GüncellenecekOtel.telefon;
                txtOtelYıldızSayısı.Text = GüncellenecekOtel.yıldızSayısı.ToString();
                txtOdaTipleri.Text = GüncellenecekOtel.odaTipleri;
                txtOtelOdaSayısı.Text = GüncellenecekOtel.odaSayısı.ToString();
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYönetici formYönetici = new FormYönetici();
            formYönetici.ShowDialog();
            this.Close();
        }
    }
}
