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
    public partial class FormMüşteriYorum : Form
    {
        DBİşlemleri db = DBİşlemleri.GetInstance();

        public string OtelAdı;
        public FormMüşteriYorum()
        {
            InitializeComponent();
        }

        private void BtnGönder_Click(object sender, EventArgs e)
        {
            Yorum yorum = new Yorum(txtYorum.Text);
            db.OtelAğacı.Ara(OtelAdı).otel.YorumEkle(yorum);
            db.YorumGönder(yorum, db.OtelAğacı.Ara(OtelAdı).otel);

            MessageBox.Show(OtelAdı + " oteline yazdığınız yorum başarıyla kaydedildi.");          
        }

        private void FormMüşteriYorum_Load(object sender, EventArgs e)
        {
            lblOtelAdı.Text += " " + OtelAdı;
        }
    }
}
