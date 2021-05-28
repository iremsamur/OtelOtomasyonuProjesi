using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otel_Otomasyonu_Projesi
{
    class GelirGiderIslemleri
    {
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        public long musteriGelirHesapla()
        {
            List<int> ucretBilgileri = new List<int>();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand ucretBilgileriGetir = new SqlCommand("SELECT Ucret FROM Table_Musteriler WHERE MONTH(CikisTarihi)=MONTH(GETDATE()) ", baglan.connect);
                SqlDataReader reader = ucretBilgileriGetir.ExecuteReader();
                while (reader.Read())
                {
                    ucretBilgileri.Add(Convert.ToInt32(reader["Ucret"]));
                }
                long toplam = 0;
                for(int i = 0; i < ucretBilgileri.Count; i++)
                {
                    toplam += ucretBilgileri[i];

                }
                return toplam;
            
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return 0;
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public double mutfakUrunleriGiderHesapla()
        {
            List<double> ucretBilgileri = new List<double>();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand ucretBilgileriGetir = new SqlCommand("SELECT UrunFiyat FROM Table_MutfakStok WHERE MONTH(GelisTarih)=MONTH(GETDATE()) ", baglan.connect);
                SqlDataReader reader = ucretBilgileriGetir.ExecuteReader();
                while (reader.Read())
                {
                    ucretBilgileri.Add(Convert.ToDouble(reader["UrunFiyat"]));
                }
                double toplam = 0;
                for (int i = 0; i < ucretBilgileri.Count; i++)
                {
                    toplam += ucretBilgileri[i];

                }
                return toplam;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return 0;
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public double odaUrunleriGiderHesapla()
        {
            List<double> ucretBilgileri = new List<double>();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand ucretBilgileriGetir = new SqlCommand("SELECT UrunFiyat FROM Table_OdaStok WHERE MONTH(GelisTarih)=MONTH(GETDATE()) ", baglan.connect);
                SqlDataReader reader = ucretBilgileriGetir.ExecuteReader();
                while (reader.Read())
                {
                    ucretBilgileri.Add(Convert.ToDouble(reader["UrunFiyat"]));
                }
                double toplam = 0;
                for (int i = 0; i < ucretBilgileri.Count; i++)
                {
                    toplam += ucretBilgileri[i];

                }
                return toplam;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return 0;
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public double personelMaasGiderHesapla()
        {
            List<double> ucretBilgileri = new List<double>();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand maasBilgileriGetir = new SqlCommand("SELECT PersonelMaas FROM Table_PersonelBilgileri ", baglan.connect);
                SqlDataReader reader = maasBilgileriGetir.ExecuteReader();
                while (reader.Read())
                {
                    ucretBilgileri.Add(Convert.ToDouble(reader["PersonelMaas"]));
                }
                double toplam = 0;
                for (int i = 0; i < ucretBilgileri.Count; i++)
                {
                    toplam += ucretBilgileri[i];

                }
                return toplam;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return 0;
            }
            finally
            {
                baglan.connect.Close();
            }
        }
        public double faturaGiderHesapla()
        {
            List<double> faturaBilgileriListesi = new List<double>();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand faturaBilgileriGetir = new SqlCommand("SELECT FaturaTutar FROM Table_Faturalar WHERE MONTH(FaturaOdemeTarih)=MONTH(GETDATE()) ", baglan.connect);
                //Bu sorguda MONTH(FaturaOdemeTarih)=MONTH(GETDATE()) kullanımı ile sadece ödeme tarihi içinde bulunduğumuz tarih olan faturaları getirir.
                //GETDATE() ile içinde bulunduğumuz tarihi getirir.
                SqlDataReader reader = faturaBilgileriGetir.ExecuteReader();
                while (reader.Read())
                {
                    faturaBilgileriListesi.Add(Convert.ToDouble(reader["FaturaTutar"]));
                }
                double toplam = 0;
                for (int i = 0; i < faturaBilgileriListesi.Count; i++)
                {
                    toplam += faturaBilgileriListesi[i];

                }
                return toplam;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return 0;
            }
            finally
            {
                baglan.connect.Close();
            }
        }
    }
}
