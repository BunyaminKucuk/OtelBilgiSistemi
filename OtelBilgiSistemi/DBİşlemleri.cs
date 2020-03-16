using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtelBilgiSistemi
{
    class DBİşlemleri
    {
       SqlConnection sqlConnection = new SqlConnection("Data Source=P-X\\SQLEXPRESS;Initial Catalog=OtelBilgiSistemi;Integrated Security=True");

       private static DBİşlemleri instance;
       public BST_Otel OtelAğacı = new BST_Otel();
       public HashTable İlTable, İlçeTable;
       public Müşteri OturumMüşteri;
       
        private DBİşlemleri()
        {
        }

      public void AğacaEkle(Otel YeniOtel)
        {
            OtelAğacı.Ekle(YeniOtel);
        }

       public void İlTableEkle(Otel YeniOtel)
        {
           İlTable.AddOtel(YeniOtel,YeniOtel.il);
        }

        void İlçeTableEkle(Otel YeniOtel)
        {
            İlçeTable.AddOtel(YeniOtel, YeniOtel.ilçe);
        }

        public static DBİşlemleri GetInstance()
        {
            if( instance==null)
            instance = new DBİşlemleri();

            return instance;
        }


        public bool MüşteriOturumu(string ad, string şifre)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT KullanıcıTürü from Kullanıcı where Ad=@p1 and Şifre=@p2", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", ad);
            cmd.Parameters.AddWithValue("@p2", şifre);

            SqlDataReader dr = cmd.ExecuteReader();

            string KullanıcıTürü = "";

            while (dr.Read())
            {
                KullanıcıTürü = dr[0].ToString().ToLower().Trim();
            }

            sqlConnection.Close();

            if (KullanıcıTürü == "müşteri")
                return true;
            else
                return false;
        }


       public bool OturumVer(string ad,string şifre)
       {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ad,Soyad,tcKimlikNo,telefon,adres,eposta from Kullanıcı where Ad=@p1 and Şifre=@p2",sqlConnection);
            cmd.Parameters.AddWithValue("@p1",ad);
            cmd.Parameters.AddWithValue("@p2",şifre);

            SqlDataReader dr = cmd.ExecuteReader();

            OturumMüşteri = new Müşteri();

            while (dr.Read())
            {
                OturumMüşteri.ad = dr[0].ToString().Trim();
                OturumMüşteri.soyad = dr[1].ToString().Trim();
                OturumMüşteri.tcKimlikNo = dr[2].ToString().Trim();
                OturumMüşteri.telefon = dr[3].ToString().Trim();
                OturumMüşteri.adres = dr[4].ToString().Trim();
                OturumMüşteri.eposta = dr[5].ToString().Trim();
            }

            sqlConnection.Close();

            if (OturumMüşteri.ad == "")
                return false;
            else
                return true;
        }



        private void İlTableAyarla()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from iltekrari",sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();

            int sayi = 0;
            while(dr.Read())
            {
                sayi = Convert.ToInt32(dr[0]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            
            this.İlTable = new HashTable(sayi);

            SqlCommand cmd1 = new SqlCommand("SELECT TekrarSayısı,İl from iltekrari", sqlConnection);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                sayi = Convert.ToInt32(dr1[0]);
                this.İlTable.HeapYeriAç(sayi, dr1[1].ToString().ToLower()); //heap yerleri açıldı
            }

            sqlConnection.Close();
        }

        private void İlçeTableAyarla()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from ilcetekrari", sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();

            int sayi = 0;
            while (dr.Read())
            {
                sayi = Convert.ToInt32(dr[0]);
            }
            sqlConnection.Close();

            sqlConnection.Open();

            this.İlçeTable = new HashTable(sayi);

            SqlCommand cmd1 = new SqlCommand("SELECT TekrarSayısı,İlçe from ilcetekrari", sqlConnection);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                sayi = Convert.ToInt32(dr1[0]);
                this.İlçeTable.HeapYeriAç(sayi, dr1[1].ToString().ToLower()); //heap yerleri açıldı
            }

            sqlConnection.Close();
        }



        public void MüşteriOtelleriAl()
        {
            İlTableAyarla();
            İlçeTableAyarla();

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT ad,il,ilçe,adres,telefon,eposta,odaTipleri,yıldızSayisi,odaSayisi,otelPuani from oteller", sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Otel otel = new Otel();

                otel.ad = dr[0].ToString().Trim();
                otel.il= dr[1].ToString().Trim();
                otel.ilçe = dr[2].ToString().Trim();
                otel.adres = dr[3].ToString().Trim();
                otel.telefon=dr[4].ToString().Trim();
                otel.eposta= dr[5].ToString().Trim();
                otel.odaTipleri = dr[6].ToString().Trim();
                otel.yıldızSayısı = Convert.ToInt32(dr[7]);
                otel.odaSayısı = Convert.ToInt32(dr[8]);
                otel.otelPuanı = Convert.ToDouble(dr[9]);

                AğacaEkle(otel);
                İlTableEkle(otel);
                İlçeTableEkle(otel);
            }
            sqlConnection.Close();
        }

        public void YöneticiOtelleriAl()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT ad,il,ilçe,adres,telefon,eposta,odaTipleri,yıldızSayisi,odaSayisi,otelPuani from oteller", sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Otel otel = new Otel();

                otel.ad = dr[0].ToString().Trim();
                otel.il = dr[1].ToString().Trim();
                otel.ilçe = dr[2].ToString().Trim();
                otel.adres = dr[3].ToString().Trim();
                otel.telefon = dr[4].ToString().Trim();
                otel.eposta = dr[5].ToString().Trim();
                otel.odaTipleri = dr[6].ToString().Trim();
                otel.yıldızSayısı = Convert.ToInt32(dr[7]);
                otel.odaSayısı = Convert.ToInt32(dr[8]);
                otel.otelPuanı = Convert.ToDouble(dr[9]);

                AğacaEkle(otel);
            }
            sqlConnection.Close();
        }

        public void PersonelleriAl()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT ad,soyad,telefon,adres,eposta,departman,pozisyon,personelPuan,tcKimlikNo,KimeAit from Personeller", sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();

            string Otel;
            while (dr.Read())
            {
                Personel personel = new Personel();

                personel.ad = dr[0].ToString().Trim();
                personel.soyad = dr[1].ToString().Trim();
                personel.telefon = dr[2].ToString().Trim();
                personel.adres = dr[3].ToString().Trim();
                personel.eposta = dr[4].ToString().Trim();
                personel.departman= dr[5].ToString().Trim();
                personel.pozisyon= dr[6].ToString().Trim();
                personel.personelPuanı = Convert.ToInt16(dr[7]);
                personel.tcKimlikNo = dr[8].ToString().Trim();
                Otel = dr[9].ToString().Trim();


                OtelAğacı.Ara(Otel).otel.PersonelEkle(personel);

               
            }
            sqlConnection.Close();
        }


        public void YorumlarıAl()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT yorum,sahipAdi,sahipSoyadi,SahipEposta,KimeAit from Yorumlar", sqlConnection);
            SqlDataReader dr = cmd.ExecuteReader();


            while(dr.Read())
            {
                Yorum yorum = new Yorum(dr[0].ToString().Trim());
                yorum.sahipAdı = dr[1].ToString().Trim();
                yorum.sahipSoyadı = dr[2].ToString().Trim();
                yorum.sahipEpostası = dr[3].ToString().Trim();
                OtelAğacı.Ara(dr[4].ToString()).otel.YorumEkle(yorum);
            }

            sqlConnection.Close();
        }

        public void YorumGönder(Yorum yorum,Otel otel)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Yorumlar(yorum,sahipAdi,sahipSoyadi,SahipEposta,KimeAit) VALUES('"+yorum.yorum+"','"+yorum.sahipAdı+"','"+yorum.sahipSoyadı+"','"+yorum.sahipEpostası+"','"+otel.ad+"')", sqlConnection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        public void OtelEkle(Otel YeniOtel)
        {           
            sqlConnection.Open();
            SqlCommand ekle = new SqlCommand("insert into Oteller(ad,il,ilçe,adres,telefon,eposta,odaTipleri,yıldızSayisi,odaSayisi,otelPuani,PuanVerilmeSayısı) VALUES('"+ YeniOtel.ad + "','"+ YeniOtel.il+ "','"+ YeniOtel.ilçe+ "','"+ YeniOtel.adres+ "','"+ YeniOtel.telefon+ "','"+ YeniOtel.eposta+ "','"+YeniOtel.odaTipleri+"','"+ YeniOtel.yıldızSayısı+ "','"+ YeniOtel.odaSayısı+ "','"+0+"','"+0+"')", sqlConnection);            

            ekle.ExecuteNonQuery();
            ekle.Dispose();
                    
            sqlConnection.Close();

            İlçeTekrarıKontrolEt(YeniOtel);
            İlTekrarıKontrolEt(YeniOtel);
            
        }

        public void OtelSime(Otel SilinecekOtel)
        {
            İlçeTekrarıKontrolEtSilme(SilinecekOtel);
            İlTekrarıKontrolEtSilme(SilinecekOtel);

          sqlConnection.Open();
          SqlCommand sil = new SqlCommand("DELETE Oteller where trim(ad)=@p1", sqlConnection);
          sil.Parameters.AddWithValue("@p1", SilinecekOtel.ad);
          sil.ExecuteNonQuery();
                   
          sqlConnection.Close();
            
        }

        public void OtelGüncelle(Otel GüncellenecekOtel)
        {          
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE  Oteller  SET adres=@p1,telefon=@p2,eposta=@p3,yıldızSayisi=@p4,odaSayisi=@p5,odaTipleri=@p6 WHERE ad=@p7", sqlConnection);

            cmd.Parameters.AddWithValue("@p1", GüncellenecekOtel.adres);
            cmd.Parameters.AddWithValue("@p2", GüncellenecekOtel.telefon);
            cmd.Parameters.AddWithValue("@p3", GüncellenecekOtel.eposta);
            cmd.Parameters.AddWithValue("@p4", GüncellenecekOtel.yıldızSayısı);
            cmd.Parameters.AddWithValue("@p5", GüncellenecekOtel.odaSayısı);
            cmd.Parameters.AddWithValue("@p6", GüncellenecekOtel.odaTipleri);
            cmd.Parameters.AddWithValue("@p7", GüncellenecekOtel.ad);
            cmd.ExecuteNonQuery();


          
            sqlConnection.Close();
            
        }

        private void İlçeTekrarıKontrolEt(Otel YeniOtel)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TekrarSayısı from ilcetekrari where İlçe=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", YeniOtel.ilçe.ToLower());
            int sayi = 0;
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                sayi = Convert.ToInt32(dr[0]);
            }

            sqlConnection.Close();
            sqlConnection.Open();


            if (sayi!=0)
            {

                SqlCommand cmd1 = new SqlCommand("UPDATE ilcetekrari SET TekrarSayısı=@p1 where İlçe=@p2", sqlConnection);
                cmd1.Parameters.AddWithValue("@p1", sayi+1);
                cmd1.Parameters.AddWithValue("@p2", YeniOtel.ilçe.ToLower());
                cmd1.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("INSERT INTO ilcetekrari(İlçe,TekrarSayısı) VALUES('"+YeniOtel.ilçe.ToLower()+"','"+1+"')", sqlConnection);

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                sqlConnection.Close();
            }
        }


        private void İlçeTekrarıKontrolEtSilme(Otel SilinecekOtel)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TekrarSayısı from ilcetekrari where İlçe=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", SilinecekOtel.ilçe.ToLower());
            int sayi = 0;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sayi = Convert.ToInt32(dr[0]);
            }

            sqlConnection.Close();
            sqlConnection.Open();


            if (sayi != 1)
            {

                SqlCommand cmd1 = new SqlCommand("UPDATE ilcetekrari SET TekrarSayısı=@p1 where İlçe=@p2", sqlConnection);
                cmd1.Parameters.AddWithValue("@p1", sayi - 1);
                cmd1.Parameters.AddWithValue("@p2", SilinecekOtel.ilçe.ToLower());
                cmd1.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("DELETE from ilcetekrari WHERE ilçe=@p1", sqlConnection);
                cmd1.Parameters.AddWithValue("@p1", SilinecekOtel.ilçe.ToLower());
                cmd1.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void İlTekrarıKontrolEt(Otel YeniOtel)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TekrarSayısı from iltekrari where İl=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", YeniOtel.il.ToLower());
            int sayi = 0;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sayi = Convert.ToInt32(dr[0]);
            }

            sqlConnection.Close();
            sqlConnection.Open();

            if (sayi != 0)
            {

                SqlCommand cmd1 = new SqlCommand("UPDATE iltekrari SET TekrarSayısı=@p1 where İl=@p2", sqlConnection);
                cmd1.Parameters.AddWithValue("@p1", sayi + 1);
                cmd1.Parameters.AddWithValue("@p2", YeniOtel.il.ToLower());
                cmd1.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("INSERT INTO iltekrari (İl,TekrarSayısı)  VALUES('" + YeniOtel.il.ToLower() + "','" + 1 + "')", sqlConnection);

                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                sqlConnection.Close();
            }
        }


        private void İlTekrarıKontrolEtSilme(Otel SilinecekOtel)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TekrarSayısı from iltekrari where İl=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", SilinecekOtel.il.ToLower());
            int sayi = 0;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sayi = Convert.ToInt32(dr[0]);
            }

            sqlConnection.Close();
            sqlConnection.Open();


            if (sayi != 1)
            {

                SqlCommand cmd1 = new SqlCommand("UPDATE iltekrari SET TekrarSayısı=@p1 where İl=@p2", sqlConnection);
                cmd1.Parameters.AddWithValue("@p1", sayi - 1);
                cmd1.Parameters.AddWithValue("@p2", SilinecekOtel.il.ToLower());
                cmd1.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("DELETE from iltekrari WHERE il=@p1", sqlConnection);
                cmd1.Parameters.AddWithValue("@p1", SilinecekOtel.il.ToLower());
                cmd1.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public double YeniPuanHesapla(Otel otel,int verilenPuan)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select otelPuani,PuanVerilmeSayısı from Oteller where ad=@p1 ", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", otel.ad);
            SqlDataReader dr = cmd.ExecuteReader();

            double otelpuanı = 0;
            int sayi = 0;
            while (dr.Read())
            {
                otelpuanı = Convert.ToDouble(dr[0]);
                sayi = Convert.ToInt32(dr[1]);              
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE Oteller SET PuanVerilmeSayısı = @p2 WHERE ad = @p3", sqlConnection);
            cmd1.Parameters.AddWithValue("@p2", sayi+1);
            cmd1.Parameters.AddWithValue("@p3", otel.ad);
            cmd1.ExecuteNonQuery();
            sqlConnection.Close();

            double YeniPuan = ((otelpuanı * sayi) + (verilenPuan)) / (sayi + 1);

            return YeniPuan;
        }

        public void PuanıGüncelle(Otel otel)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Oteller SET otelPuani=@p1 WHERE  ad=@p2 ", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", otel.otelPuanı);
            cmd.Parameters.AddWithValue("@p2",otel.ad);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void PersonelEkle(Personel personel,string OtelAdı)
        {
            
                sqlConnection.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO Personeller(tcKimlikNo,ad,soyad,telefon,adres,departman,pozisyon,personelPuan,eposta,KimeAit)  VALUES('"+ personel.tcKimlikNo + "','"+ personel.ad + "','"+ personel.soyad + "','"+ personel.telefon + "','"+ personel.adres+ "','"+ personel.departman + "','"+ personel.pozisyon + "','"+ personel.personelPuanı + "','"+personel.eposta+"','"+ OtelAdı + "')",sqlConnection);

                ekle.ExecuteNonQuery();
   
                ekle.Dispose();
           
            
                sqlConnection.Close();
            
        }

        public void PersonelSil(Personel personel)
        {
            
                sqlConnection.Open();
                SqlCommand sil = new SqlCommand("delete Personeller where tcKimlikNo=@p1", sqlConnection);
                sil.Parameters.AddWithValue("@p1",personel.tcKimlikNo);
                sil.ExecuteNonQuery();
                    
         
                sqlConnection.Close();
            
        }

        public void PersonelGüncelle(Personel personel)
        {
           
                sqlConnection.Open();
                SqlCommand güncelle = new SqlCommand("UPDATE Personeller set ad=@ad,soyad=@soyad,telefon=@telefon,adres=@adres,departman=@departman,pozisyon=@pozisyon,personelPuan=@personelPuan where tcKimlikNo=@tcKimlikNo", sqlConnection);
                güncelle.Parameters.AddWithValue("@tcKimlikNo", personel.tcKimlikNo);
                güncelle.Parameters.AddWithValue("@ad", personel.ad);
                güncelle.Parameters.AddWithValue("@soyad", personel.soyad);
                güncelle.Parameters.AddWithValue("@telefon", personel.telefon);
                güncelle.Parameters.AddWithValue("@adres", personel.adres);
                güncelle.Parameters.AddWithValue("@departman", personel.departman);
                güncelle.Parameters.AddWithValue("@pozisyon", personel.pozisyon);
                güncelle.Parameters.AddWithValue("@personelPuan", Convert.ToInt16(personel.personelPuanı));
                güncelle.ExecuteNonQuery();
           
                sqlConnection.Close();
            
        }

    }

   
}
