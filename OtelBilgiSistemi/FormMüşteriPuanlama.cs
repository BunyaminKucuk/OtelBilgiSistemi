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
    public partial class FormMüşteriPuanlama : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();

        public FormMüşteriPuanlama()
        {
            InitializeComponent();
        }

        public string oteladı;

        private void FormMüşteriPuanlama_Load(object sender, EventArgs e)
        {
            lblAd.Text += " " + oteladı;
        }

        private void BtnPuan_Click(object sender, EventArgs e)
        {
            int verilenPuan = Convert.ToInt16(cmbPuan.Text);
            db.OtelAğacı.Ara(oteladı).otel.otelPuanı = db.YeniPuanHesapla(db.OtelAğacı.Ara(oteladı).otel, verilenPuan); //dbden alınan bilgilerle puanı hesaplayıp otele koy
            db.PuanıGüncelle(db.OtelAğacı.Ara(oteladı).otel); //yeni puanı dbye gönder
            MessageBox.Show("Puanı Başarıyla gönderdiniz");
        }
    }
}
