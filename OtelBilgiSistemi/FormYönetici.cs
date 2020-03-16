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
    public partial class FormYönetici : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();
       public bool ilkAçılış = true;

        public FormYönetici()
        {
            InitializeComponent();
        }

        private void FormYönetici_Load(object sender, EventArgs e)
        {
            if(ilkAçılış)
            {
                db.YöneticiOtelleriAl();
                db.YorumlarıAl();
                db.PersonelleriAl();
                db.OtelAğacı.InOrder();
            }
            
            foreach (Otel a in db.OtelAğacı.oteller) //listboxu otellerin adlarıyla doldur 
                lboxOteller.Items.Add(a.ad);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            if (lboxOteller.SelectedItem == null)
            {
                MessageBox.Show("Otel seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.OtelSime(db.OtelAğacı.Ara(lboxOteller.SelectedItem.ToString()).otel);
            db.OtelAğacı.Sil(lboxOteller.SelectedItem.ToString());
            MessageBox.Show("Otel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lboxOteller.Items.Remove(lboxOteller.SelectedItem);



        }

        private void LboxOteller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OtelNode temp = db.OtelAğacı.Ara(lboxOteller.SelectedItem.ToString());

                lblOtelİl.Text = "İl: " + temp.otel.il;
                lblOtelAdres.Text = "Adres: " + temp.otel.adres;
                lblOtelEposta.Text = "Eposta: " + temp.otel.eposta;
                lblOtelTelefon.Text = "Telefon: " + temp.otel.telefon;
                lblOtelİlçe.Text = "İlçe: " + temp.otel.ilçe;
                lblOtelOdaSayısı.Text = "Oda sayısı:" + temp.otel.odaSayısı.ToString();
                lblOtelPuan.Text = "Puan: " + temp.otel.otelPuanı.ToString();
                lblOtelYıldız.Text = "Yıldız: " + temp.otel.yıldızSayısı.ToString();
                lblOdaTipleri.Text = "Oda tipleri: " + temp.otel.odaTipleri.ToString();

                txtYorumlar.Text = "";
                foreach (Yorum a in temp.otel.yorumlar)
                {
                    txtYorumlar.Text += a.yorum + Environment.NewLine + "Yorum Yapan: " + a.sahipAdı + Environment.NewLine + "-----------------------------------" + Environment.NewLine;
                }
            }
            catch
            {
                
            }
        }

        private void BtnUygula_Click(object sender, EventArgs e)
        {
            lblFiltreleme.Text = "Filtreleme: " + cmbFiltre.Text;

            lboxOteller.Items.Clear();

            if (cmbFiltre.Text=="İl")
            {              
                foreach(Otel a in db.OtelAğacı.oteller)
                {
                    if (a.il.ToLower() == txtAranan.Text.ToLower())
                        lboxOteller.Items.Add(a.ad);
                }

                if(lboxOteller.Items.Count==0)
                  MessageBox.Show("Bu ilden bir otel bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                return;
            }
            else if(cmbFiltre.Text == "İlçe")
            {
                foreach (Otel a in db.OtelAğacı.oteller)
                {
                    if (a.ilçe.ToLower() == txtAranan.Text.ToLower())
                        lboxOteller.Items.Add(a.ad);
                }

                if (lboxOteller.Items.Count == 0)
                    MessageBox.Show("Bu ilçeden bir otel bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

           
        }

        private void BtnKaldır_Click(object sender, EventArgs e)
        {
            lboxOteller.Items.Clear();

            foreach (Otel a in db.OtelAğacı.oteller) //listboxu otellerin adlarıyla doldur 
                lboxOteller.Items.Add(a.ad);

            lblFiltreleme.Text = "Filtreleme: Yok";
        }

        private void BtnOtelEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYöneticiOtelEkleGüncelle formYöneticiOtelEkleGüncelle = new FormYöneticiOtelEkleGüncelle();
            formYöneticiOtelEkleGüncelle.ShowDialog();
            this.Close();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (lboxOteller.SelectedItem == null)
            {
                MessageBox.Show("Otel seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormYöneticiOtelEkleGüncelle formYöneticiOtelEkleGüncelle = new FormYöneticiOtelEkleGüncelle();
                formYöneticiOtelEkleGüncelle.İstek = "güncelle";
                formYöneticiOtelEkleGüncelle.GüncellenecekOtel = db.OtelAğacı.Ara(lboxOteller.SelectedItem.ToString()).otel;
                this.Hide();
                this.Close();
                formYöneticiOtelEkleGüncelle.ShowDialog();
            
            
            

        }

        private void BtnPersonelİşlemleri_Click(object sender, EventArgs e)
        {
            if (lboxOteller.SelectedItem == null)
            {
                MessageBox.Show("Otel seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            FormYöneticiPersonelİşlemleri formYöneticiPersonelİşlemleri = new FormYöneticiPersonelİşlemleri();
            formYöneticiPersonelİşlemleri.Otel = db.OtelAğacı.Ara(lboxOteller.SelectedItem.ToString()).otel;
            formYöneticiPersonelİşlemleri.ShowDialog();
            this.Close();
        }
    }
}
