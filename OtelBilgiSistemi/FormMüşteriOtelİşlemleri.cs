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
    public partial class FormMüşteriOtelİşlemleri : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();
       

        public FormMüşteriOtelİşlemleri()
        {
            InitializeComponent();
           
        }

        private void FormMüşteriOtelİşlemleri_Load(object sender, EventArgs e)
        {
            foreach (Otel a in db.OtelAğacı.oteller) //listboxu otellerin adlarıyla doldur 
                  lboxOteller.Items.Add(a.ad);

            cmbSıralama.SelectedIndex = 0; 
        }

        private void LboxOteller_SelectedIndexChanged(object sender, EventArgs e) //listboxtaki bir otel adı seçildiğinde bütün bilgileri yazılsın
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
                foreach(Yorum a in temp.otel.yorumlar)
                {
                    txtYorumlar.Text += a.yorum + Environment.NewLine + "Yorum Yapan: " + a.sahipAdı + Environment.NewLine +"-----------------------------------" + Environment.NewLine;
                }
            }
            catch
            {
                
            }
           
        }

        private void btnYorum_Click(object sender, EventArgs e)
        {
            try
            {    
                FormMüşteriYorum formMüşteriYorum = new FormMüşteriYorum();
                formMüşteriYorum.OtelAdı = lboxOteller.SelectedItem.ToString();
                formMüşteriYorum.Show();
            }
            catch
            {
                MessageBox.Show("Otel seçilmedi." ,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnPuan_Click(object sender, EventArgs e)
        {           
            FormMüşteriPuanlama form = new FormMüşteriPuanlama();
            form.oteladı = lboxOteller.SelectedItem.ToString();
            form.ShowDialog();                   
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if(txtAranan.Text=="" && cmbFiltre.Text != "") //filtreleme türü seçildiği halde kıstas girilmez ise
            {
                MessageBox.Show("Herhangi bir kıstas girmediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(cmbFiltre.Text != "") //filtre seçildiyse listeyi sıfırla
            lboxOteller.Items.Clear();
                       
                if (cmbFiltre.Text == "İl")
                {
                    try
                    {
                        foreach (Otel a in db.İlTable.GetHeap(txtAranan.Text.ToLower()).heapArray)
                        {
                            lboxOteller.Items.Add(a.ad);
                        }
                }
                    catch
                    {
                        MessageBox.Show("Bu ilden bir otel bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       return;
                    }
                }
                else if (cmbFiltre.Text == "İlçe")
                {
                    try
                    {
                        foreach (Otel a in db.İlçeTable.GetHeap(txtAranan.Text.ToLower()).heapArray)
                        {
                            lboxOteller.Items.Add(a.ad);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Bu ilçeden bir otel bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else if (cmbFiltre.Text == "En az puan")
                {
                
                    foreach (Otel a in db.OtelAğacı.oteller)
                    {
                        if (a.otelPuanı >= Convert.ToInt16(txtAranan.Text))
                            lboxOteller.Items.Add(a.ad);
                    }  
                }
               else if (cmbFiltre.Text == "En az yıldız")
               {
                foreach (Otel a in db.OtelAğacı.oteller)
                {
                    if (a.yıldızSayısı >= Convert.ToInt16(txtAranan.Text))
                        lboxOteller.Items.Add(a.ad);
                }                
               }

                if(lboxOteller.Items.Count==0) //filtrelere uygun otel yoksa sıralamaya gerek yoktur bu yüzden return
                {
                  MessageBox.Show("Aradığınız filtrede herhangi bir otel bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
                }


             

                // ------------------------SIRALAMA KISMI---------------------------------------

            if(cmbSıralama.Text=="Ad (A-Z)") //SIRALAMA 1
            {
                lboxOteller.Sorted = true;
            }
            else if (cmbSıralama.Text == "Ad (Z-A)") //SIRALAMA 2
            {
               List<string> TersSıralama = new List<string>();

                foreach (string a in lboxOteller.Items)
                    TersSıralama.Add(a);

                TersSıralama.Reverse();

                lboxSıfırla();

                foreach (string a in TersSıralama)
                    lboxOteller.Items.Add(a);

            }
            else if (cmbSıralama.Text == "Yıldız (Yüksekten Düşüğe)") //SIRALAMA 3
            {              
                if (cmbFiltre.Text == "İl")
                {
                  lboxSıfırla();
                  lboxDoldurYıldız(db.İlTable);
                }                   
                else if (cmbFiltre.Text == "İlçe")
                {
                    lboxSıfırla();
                    lboxDoldurYıldız(db.İlçeTable);
                }
                else
                {
                    Otel[] YıldızSorted = new Otel[lboxOteller.Items.Count];
                    int i = 0;
                    
                    foreach (string a in lboxOteller.Items)
                    {
                        YıldızSorted[i++] = db.OtelAğacı.Ara(a).otel;                       
                    }
                    lboxSıfırla();

                    YıldızSortedOtelVer(YıldızSorted);

                    foreach (Otel a in YıldızSorted)
                    {
                        lboxOteller.Items.Add(a.ad);
                    }
                }
            }       
            else if (cmbSıralama.Text == "Puan (Yüksekten Düşüğe)") //SIRALAMA 4
            {                
                if (cmbFiltre.Text=="İl")
                {
                    lboxSıfırla();
                    lboxDoldurPuan(db.İlTable);
                }             
               else if (cmbFiltre.Text == "İlçe")
                {
                    lboxSıfırla();
                    lboxDoldurPuan(db.İlçeTable);
                }
                else
                {
                    Otel[] PuanSorted = new Otel[lboxOteller.Items.Count];
                    int i = 0;

                    foreach (string a in lboxOteller.Items)
                    {
                        PuanSorted[i++] = db.OtelAğacı.Ara(a).otel;
                    }
                    lboxSıfırla();

                    PuanSortedOtelVer(PuanSorted);
                
                    foreach (Otel a in PuanSorted)
                    {
                        lboxOteller.Items.Add(a.ad);
                    }
                }
            }
            lblFiltreleme.Text = "Filtreleme: " + cmbFiltre.Text;
            lblSıralama.Text = "Sıralama: " + cmbSıralama.Text;

        }

        

        private void BtnKaldır_Click(object sender, EventArgs e) //filtreleme sıfırla
        {
            lboxOteller.Items.Clear();
            txtAranan.ResetText();
            lblFiltreleme.Text = "Filtreleme: Yok";
          
            foreach (Otel a in db.OtelAğacı.oteller)
                lboxOteller.Items.Add(a.ad);
        }

        private void BtnGeri_Click(object sender, EventArgs e) //ilk sayfaya geri dön
        {
            this.Hide();
            FormMüşteri formMüşteri = new FormMüşteri();
            formMüşteri.ilkAçılış = false;
            formMüşteri.ShowDialog();
            this.Close();
        }
        private void YıldızSortedOtelVer(Otel[] Sıra) //otelleri yıldızlarına göre sırala
        {
            for (int i = 0; i < Sıra.Length; i++)
                for (int j = i + 1; j < Sıra.Length; j++)
                {
                    if (Sıra[i].yıldızSayısı < Sıra[j].yıldızSayısı)
                    {
                        Otel temp = Sıra[i];
                        Sıra[i] = Sıra[j];
                        Sıra[j] = temp;
                    }
                }
        }

        private void PuanSortedOtelVer(Otel[] Sıra) //otelleri puanlarına göre sırala
        {
            for (int i = 0; i < Sıra.Length; i++)
                for (int j = i + 1; j < Sıra.Length; j++)
                {
                    if (Sıra[i].otelPuanı < Sıra[j].otelPuanı)
                    {
                        Otel temp = Sıra[i];
                        Sıra[i] = Sıra[j];
                        Sıra[j] = temp;
                    }
                }
        }

        private void lboxSıfırla()
        {
            lboxOteller.Items.Clear();
            lboxOteller.Sorted = false;
        }

        private void lboxDoldurPuan(HashTable b)
        {
            foreach (string a in b.GetHeap(txtAranan.Text.ToLower()).Sort())
            {
                lboxOteller.Items.Add(a);
            }
        }
        private void lboxDoldurYıldız(HashTable b)
        {
            foreach (string a in b.GetHeap(txtAranan.Text.ToLower()).YıldızSort())
            {
                lboxOteller.Items.Add(a);
            }
        }
    }
}
