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
    public partial class FormYöneticiPersonelİşlemleri : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();
        public Otel Otel;

        public FormYöneticiPersonelİşlemleri()
        {
            InitializeComponent();
        }

        private void FormYöneticiPersonelİşlemleri_Load(object sender, EventArgs e)
        {
            lblOtel.Text = Otel.ad;
            cmbSıralama.SelectedIndex = 0;

            foreach (Personel a in Otel.personeller)
                lboxPersoneller.Items.Add(a.ad);            
        }

        private void LboxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Personel temp = Otel.PersonelAra(lboxPersoneller.SelectedItem.ToString());

                lblPersonelAd.Text ="Ad: "+temp.ad;
                lblPersonelSoyad.Text = "Soyad: " + temp.soyad;
                lblPersonelTC.Text = "TC NO: " + temp.tcKimlikNo;
                lblPersonelTelefon.Text = "Telefon: " + temp.telefon;
                lblPersonelEposta.Text = "Eposta: " + temp.eposta;
                lblPersonelAdres.Text = "Adres: " + temp.adres;
                lblPersonelPozisyon.Text = "Pozisyon: " + temp.pozisyon;
                lblPersonelDepartman.Text = "Departman: " + temp.departman;
                lblPersonelPuan.Text = "Puan: " + temp.personelPuanı.ToString();
            }
            catch
            {

            }
        }

        private void BtnOtelEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYöneticiPersonelEkleGüncelle formYöneticiPersonelEkleGüncelle = new FormYöneticiPersonelEkleGüncelle();
            formYöneticiPersonelEkleGüncelle.İşlemYapılacakOtel = Otel;
            formYöneticiPersonelEkleGüncelle.ShowDialog();
            this.Close();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lboxPersoneller.SelectedItem == null)
            {
                MessageBox.Show("Personel seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            Personel ÇıkarılacakPersonel = db.OtelAğacı.Ara(Otel.ad).otel.PersonelAra(lboxPersoneller.SelectedItem.ToString());
            db.OtelAğacı.Ara(Otel.ad).otel.PersonelÇıkar(ÇıkarılacakPersonel);
            db.PersonelSil(ÇıkarılacakPersonel);
            lboxPersoneller.Items.Remove(lboxPersoneller.SelectedItem);
            Personel.PersonelSil(ÇıkarılacakPersonel);

            MessageBox.Show("Personel silindi.");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (lboxPersoneller.SelectedItem == null)
            {
                MessageBox.Show("Personel seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            FormYöneticiPersonelEkleGüncelle formYöneticiPersonelEkleGüncelle = new FormYöneticiPersonelEkleGüncelle();
            formYöneticiPersonelEkleGüncelle.İstek = "güncelle";
            formYöneticiPersonelEkleGüncelle.GüncellenecekPersonel = db.OtelAğacı.Ara(Otel.ad).otel.PersonelAra(lboxPersoneller.SelectedItem.ToString());
            formYöneticiPersonelEkleGüncelle.İşlemYapılacakOtel = Otel;
            formYöneticiPersonelEkleGüncelle.ShowDialog();
            this.Close();
        }

        private void BtnUygula_Click(object sender, EventArgs e)
        {
            lboxPersoneller.Items.Clear();
            bool DepartmanVar = cmbDepartman.Text != "";
            lboxPersoneller.Sorted = false;

  
            if (cmbSıralama.Text== "Puan (Yüksekten düşüğe)")
            {             
                if(DepartmanVar)
                {
                    foreach (Personel a in PuanSortedPersonelVer(Otel.personeller))
                    {
                        if(cmbDepartman.Text.ToLower()==a.departman.ToLower())
                            lboxPersoneller.Items.Add(a.ad);
                    }                       
                }
                else
                {
                    foreach (Personel a in PuanSortedPersonelVer(Otel.personeller))
                        lboxPersoneller.Items.Add(a.ad);
                }                                  
            }
            else if(cmbSıralama.Text == "Ad (A-Z)")
            {
                if(DepartmanVar)
                {
                    foreach (Personel a in Otel.personeller)
                    {
                        if (a.departman.ToLower() == cmbDepartman.Text.ToLower())
                            lboxPersoneller.Items.Add(a.ad);
                    }
                }
                else
                {
                    foreach (Personel a in Otel.personeller)
                    {
                        lboxPersoneller.Items.Add(a.ad);
                    }
                    lboxPersoneller.Sorted = true;
                }                          
            }

            lblDepartman.Text = "Departman: " + cmbDepartman.Text;
            lblSıralama.Text = "Sıralama: " + cmbSıralama.Text;

            if (lboxPersoneller.Items.Count == 0)
                MessageBox.Show("Bu departmanda personel bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private Personel[] PuanSortedPersonelVer(LinkedList<Personel> Sıra) //Personelleri puanlarına göre sırala
        {
            Personel[] personels = new Personel[Sıra.Count];
            int x = 0;

            foreach(Personel a in Sıra)
              personels[x++] = a;
                         
            for (int i = 0; i < personels.Length; i++)
                for (int j = i + 1; j < personels.Length; j++)
                {
                    if (personels[i].personelPuanı < personels[j].personelPuanı)
                    {
                        Personel temp = personels[i];
                            personels[i] = personels[j];
                            personels[j] = temp;
                    }
                }

            return personels;
        }

        private void BtnKaldır_Click(object sender, EventArgs e)
        {
            lboxPersoneller.Items.Clear();

            foreach (Personel a in Otel.personeller)
                lboxPersoneller.Items.Add(a.ad);

            lboxPersoneller.Sorted = true;

            lblDepartman.Text = "Departman:Yok";
            lblSıralama.Text = "Sıralama:Ad (A-Z)";

        }

        private void BtnEnYüksek_Click(object sender, EventArgs e)
        {
            if(Otel.personeller == null)
            {
                MessageBox.Show("Personeliniz yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Personel enyüksek = PuanSortedPersonelVer(Otel.personeller)[0];
            MessageBox.Show("En yüksek puanlı personel:" + enyüksek.ad + " Puanı:" + enyüksek.personelPuanı);
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYönetici formYönetici = new FormYönetici();
            formYönetici.ilkAçılış = false;
            formYönetici.ShowDialog();
            this.Close();
        }
    }
}
