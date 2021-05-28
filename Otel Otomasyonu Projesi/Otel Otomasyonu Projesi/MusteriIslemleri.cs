using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Otel_Otomasyonu_Projesi
{
    class MusteriIslemleri
    {
        
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        private string adSoyad;
        public string musteriAdiSoyadi
        {
            get
            {
                return adSoyad;
            }
            set
            {
                adSoyad = value;
            }
        }
        
        
        public void odaDurumuGuncelle(int odaNo,string musteriAdSoyad,string cikisTarih)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand odaDurumGuncelle = new SqlCommand("UPDATE Table_Odalar SET OdadaKalankisi=@alanMusteri,OdaDurumu=@durum,CikisTarih=@cikisTarih WHERE OdaAdi=@odaAdi", baglan.connect);
                odaDurumGuncelle.Parameters.AddWithValue("@alanMusteri", musteriAdSoyad);
                odaDurumGuncelle.Parameters.AddWithValue("@durum", "Dolu");
                odaDurumGuncelle.Parameters.AddWithValue("@cikisTarih", cikisTarih);
                odaDurumGuncelle.Parameters.AddWithValue("@odaAdi", odaNo);
                odaDurumGuncelle.ExecuteNonQuery();
                odaDurumGuncelle.Dispose();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public void odaDurumuGuncelle2(int odaNo)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand odaDurumGuncelle = new SqlCommand("UPDATE Table_Odalar SET OdadaKalankisi=@alanMusteri,OdaDurumu=@durum,CikisTarih=@cikisTarih WHERE OdaAdi=@odaAdi", baglan.connect);
                odaDurumGuncelle.Parameters.AddWithValue("@alanMusteri","");
                odaDurumGuncelle.Parameters.AddWithValue("@durum", "Boş");
                odaDurumGuncelle.Parameters.AddWithValue("@cikisTarih", "");
                odaDurumGuncelle.Parameters.AddWithValue("@odaAdi", odaNo);
                odaDurumGuncelle.ExecuteNonQuery();
                odaDurumGuncelle.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public List<string> odaDurumuGetir()
        {
            //odaların durumlarını getirerek bir string listeye atar ve bu listeyi döndürür.
            List<string> liste = new List<string>();
            string tarih = DateTime.Now.ToString("d");
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand odaDurumGetir = new SqlCommand("SELECT * FROM Table_Odalar WHERE OdaDurumu=@durum AND CikisTarih!=@tarih", baglan.connect);
                odaDurumGetir.Parameters.AddWithValue("@durum", "Dolu");
                odaDurumGetir.Parameters.AddWithValue("@tarih", tarih);
                SqlDataReader reader = odaDurumGetir.ExecuteReader();
                while (reader.Read())
                {
                    liste.Add(reader["OdaAdi"].ToString());//Kayıtlardan sadece OdaAdi sütunlarını getirip listeye ekler.
                }
                return liste;

                
               
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return null;
            }
            finally
            {
                baglan.connect.Close();
            }

        }
        public void musteriKayitAl(string adi,string soyadi,string cinsiyet,string telNo,string adres,string mailAdresi,string tc,int odaNo,string ucret,DateTime girisTarih,DateTime cikisTarih,string musteriOdaTuru)
        {
            if(baglan.connect.State== System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand yeniMusteriEkle = new SqlCommand("INSERT INTO Table_Musteriler VALUES(@MusteriAdi,@MusteriSoyadi,@MusteriCinsiyet,@MusteriTelefon,@MusteriMail,@MusteriAdres,@MusteriTc,@OdaNo,@Ucret,@GirisTarihi,@CikisTarihi,@MusteriOdaTuru)", baglan.connect);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriAdi", adi);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriSoyadi", soyadi);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriCinsiyet", cinsiyet);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriTelefon", telNo);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriMail", adres);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriAdres", mailAdresi);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriTc", tc);
                yeniMusteriEkle.Parameters.AddWithValue("@OdaNo", odaNo);
                yeniMusteriEkle.Parameters.AddWithValue("@Ucret", ucret);
                yeniMusteriEkle.Parameters.AddWithValue("@GirisTarihi", girisTarih);
                yeniMusteriEkle.Parameters.AddWithValue("@CikisTarihi", cikisTarih);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriOdaTuru", musteriOdaTuru);
                yeniMusteriEkle.ExecuteNonQuery();
                MessageBox.Show("Müşteri kaydı başarılı bir şekilde oluşmuştur : \n  "+odaNo+" numaralı oda "+adi+" "+soyadi+" isimli müşteriye verilmiştir.", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yeniMusteriEkle.Dispose();
                musteriAdiSoyadi = adi + " " + soyadi;
                odaDurumuGuncelle(odaNo, musteriAdiSoyadi,cikisTarih.ToString("d"));
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public void MusteriSil(int id, int odaNo)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand musteriSil = new SqlCommand("DELETE FROM Table_Musteriler WHERE MusteriId=@id", baglan.connect);
                musteriSil.Parameters.AddWithValue("@id", id);
                musteriSil.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla silindi ", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                odaDurumuGuncelle2(odaNo);//silinen müşteriye göre , o müşterinin kaldığı odanın durumunu günceller .

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public void MusteriBilgiGuncelle(int id, string adi, string soyadi, string cinsiyet, string telNo, string adres, string mailAdresi, string tc, int odaNo, string ucret, DateTime girisTarih, DateTime cikisTarih, string musteriOdaTuru)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand bilgiGuncelle = new SqlCommand("UPDATE Table_Musteriler SET MusteriAdi=@adi,MusteriSoyadi=@soyadi,MusteriCinsiyet=@cinsiyet,MusteriTelefon=@telefon,MusteriMail=@mail,MusteriAdres=@adres,MusteriTc=@tc,OdaNo=@odano,Ucret=@ucret,GirisTarihi=@girisTarih,CikisTarihi=@cikisTarih,MusteriOdaTuru=@musteriodaturu WHERE MusteriId=@id", baglan.connect);
                bilgiGuncelle.Parameters.AddWithValue("@adi", adi);
                bilgiGuncelle.Parameters.AddWithValue("@soyadi", soyadi);
                bilgiGuncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                bilgiGuncelle.Parameters.AddWithValue("@telefon", telNo);
                bilgiGuncelle.Parameters.AddWithValue("@mail",mailAdresi);
                bilgiGuncelle.Parameters.AddWithValue("@adres", adres);
                bilgiGuncelle.Parameters.AddWithValue("@tc", tc);
                bilgiGuncelle.Parameters.AddWithValue("@odano", odaNo);
                bilgiGuncelle.Parameters.AddWithValue("@ucret", ucret);
                bilgiGuncelle.Parameters.AddWithValue("@girisTarih", girisTarih);
                bilgiGuncelle.Parameters.AddWithValue("@cikisTarih", cikisTarih);
                bilgiGuncelle.Parameters.AddWithValue("@musteriodaturu",musteriOdaTuru);
                bilgiGuncelle.Parameters.AddWithValue("@id", id);


                bilgiGuncelle.ExecuteNonQuery();
                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi  ", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);



            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
            }
            finally
            {
                baglan.connect.Close();
            }
        }





    }
}
