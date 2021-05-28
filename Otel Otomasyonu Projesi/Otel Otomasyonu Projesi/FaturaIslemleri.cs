using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Otel_Otomasyonu_Projesi
{
    class FaturaIslemleri
    {
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        public void faturaEkle(string faturaAdi,string faturaTutar,DateTime faturaOdemeTarih)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO Table_Faturalar VALUES(@FaturaAdi,@FaturaTutar,@FaturaOdemeTarih)", baglan.connect);
                ekle.Parameters.AddWithValue("@FaturaAdi", faturaAdi);
                ekle.Parameters.AddWithValue("@FaturaTutar", faturaTutar);
                ekle.Parameters.AddWithValue("@FaturaOdemeTarih", faturaOdemeTarih);

                ekle.ExecuteNonQuery();
                MessageBox.Show("Yeni fatura başarıyla eklendi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);



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
        public DataTable faturalariListele()
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand faturalariGetir = new SqlCommand("SELECT * FROM Table_Faturalar", baglan.connect);
                SqlDataAdapter adapter = new SqlDataAdapter(faturalariGetir);
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                return tablo;





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

        public void faturaBilgiGuncelle(int id, string faturaAdi, string faturaTutar,DateTime faturaOdemeTarihi)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand faturalariGuncelle = new SqlCommand("UPDATE Table_Faturalar SET FaturaAdi=@faturaAdi,FaturaTutar=@faturaTutar,FaturaOdemeTarih=@faturaOdemeTarih WHERE FaturaId=@id", baglan.connect);
                faturalariGuncelle.Parameters.AddWithValue("@faturaAdi", faturaAdi);
                faturalariGuncelle.Parameters.AddWithValue("@faturaTutar", faturaTutar);
                faturalariGuncelle.Parameters.AddWithValue("@FaturaOdemeTarih", faturaOdemeTarihi);

                faturalariGuncelle.Parameters.AddWithValue("@id", id);
                faturalariGuncelle.ExecuteNonQuery();
                MessageBox.Show("Fatura bilgileri başarıyla güncellendi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public void faturaBilgiSil(int id)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand urunSil = new SqlCommand("DELETE Table_Faturalar WHERE FaturaId=@id", baglan.connect);

                urunSil.Parameters.AddWithValue("@id", id);
                urunSil.ExecuteNonQuery();
                MessageBox.Show("Fatura başarıyla silindi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
