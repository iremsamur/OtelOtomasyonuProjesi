using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Otel_Otomasyonu_Projesi
{
    class Odalar
    {
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        private string odadaKalanKisi;
        private string durum;
        private string btnAdi;
        public string alanKisi
        {
            get
            {
                return alanKisi;
            }
            set
            {
                odadaKalanKisi = value;
            }
        }
        public string odaDurum
        {
            get
            {
                return durum;
            }
            set
            {
               durum = value;
            }
        }
        public string ButonAdi
        {
            get
            {
                return btnAdi;
            }
            set
            {
                btnAdi = value;
            }
        }
        public List<string> odaBilgileriGetir(int odaAdi,string durum)
        {
            List<string> liste = new List<string>();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand odalariGetir = new SqlCommand("SELECT * FROM Table_Odalar WHERE OdaAdi=@odaAdi AND OdaDurumu=@odaDurumu",baglan.connect);
                odalariGetir.Parameters.AddWithValue("@odaAdi", odaAdi);
                odalariGetir.Parameters.AddWithValue("@odaDurumu", durum);
                SqlDataReader odaOku = odalariGetir.ExecuteReader();
                if (odaOku.Read())
                {
                  
                    liste.Add(odaOku["OdadaKalanKisi"].ToString());
                   
                }
                return liste;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu!!!" + hata.Message);
                return null;
            }
            finally
            {
                baglan.connect.Close();
            }

        }
        public List<string> odadurumGetir()
        {
            List<string> liste = new List<string>();
            string tarih = DateTime.Now.ToString("d");
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand odaDurumGetir = new SqlCommand("SELECT * FROM Table_Odalar WHERE OdaDurumu=@durum ", baglan.connect);
                odaDurumGetir.Parameters.AddWithValue("@durum", "Dolu");
                
                SqlDataReader reader = odaDurumGetir.ExecuteReader();
                while (reader.Read())
                {
                    liste.Add(reader["OdaAdi"].ToString());
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
    }
}
