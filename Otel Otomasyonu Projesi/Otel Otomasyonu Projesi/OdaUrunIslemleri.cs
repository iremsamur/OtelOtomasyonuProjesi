using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Otel_Otomasyonu_Projesi
{
    class OdaUrunIslemleri
    {
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();

        public ArrayList kategoriler2 = new ArrayList();
        public void odaUrunEkle(string urunAdi, string kategoriAdi, string urunAdet, string urunFiyat, string firmaAdi, DateTime gelisTarih)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO Table_OdaStok VALUES(@UrunAdi,@UrunKategoriAdi,@UrunAdet,@UrunFiyat,@FirmaAdi,@GelisTarih)", baglan.connect);
                ekle.Parameters.AddWithValue("@UrunAdi", urunAdi);
                ekle.Parameters.AddWithValue("@UrunKategoriAdi", kategoriAdi);
                ekle.Parameters.AddWithValue("@UrunAdet", urunAdet);
                ekle.Parameters.AddWithValue("@UrunFiyat", urunFiyat);
                ekle.Parameters.AddWithValue("@FirmaAdi", firmaAdi);
                ekle.Parameters.AddWithValue("@GelisTarih", gelisTarih);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);



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
        
        public DataTable odaUrunleriListele()
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand urunleriGetir = new SqlCommand("SELECT * FROM Table_OdaStok", baglan.connect);
                SqlDataAdapter adapter = new SqlDataAdapter(urunleriGetir);
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
        public void odaUrunBilgiGuncelle(int id, string urunAdi, string kategoriAdi, string urunAdet, string urunFiyat, string firmaAdi, DateTime gelisTarih)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand urunleriGuncelle = new SqlCommand("UPDATE Table_OdaStok SET UrunAdi=@urunAdi,UrunKategoriAdi=@urunKategori,UrunAdet=@urunAdet,UrunFiyat=@urunFiyat,FirmaAdi=@firmaAdi,GelisTarih=@gelisTarih WHERE MutfakUrunId=@id", baglan.connect);
                urunleriGuncelle.Parameters.AddWithValue("@urunAdi", urunAdi);
                urunleriGuncelle.Parameters.AddWithValue("@urunKategori", kategoriAdi);
                urunleriGuncelle.Parameters.AddWithValue("@urunAdet", urunAdet);
                urunleriGuncelle.Parameters.AddWithValue("@urunFiyat", urunFiyat);
                urunleriGuncelle.Parameters.AddWithValue("@firmaAdi", firmaAdi);
                urunleriGuncelle.Parameters.AddWithValue("@gelisTarih", gelisTarih);
                urunleriGuncelle.Parameters.AddWithValue("@id", id);
                urunleriGuncelle.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla güncellendi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public void odaUrunBilgiSil(int id)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand urunSil = new SqlCommand("DELETE Table_OdaStok WHERE UrunId=@id", baglan.connect);

                urunSil.Parameters.AddWithValue("@id", id);
                urunSil.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla silindi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public void odaKategoriGetir()
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                kategoriler2.Clear();
                SqlCommand odaKategoriler = new SqlCommand("SELECT * FROM Table_OdaKategori", baglan.connect);
                SqlDataReader reader = odaKategoriler.ExecuteReader();
                while (reader.Read())
                {
                    kategoriler2.Add(reader["KategoriAdi"].ToString());


                }








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
        public DataTable odaIstenenUrunleriListele(string urunAdi)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand urunleriGetir = new SqlCommand("SELECT * FROM Table_OdaStok WHERE UrunAdi=@urunAdi", baglan.connect);
                urunleriGetir.Parameters.AddWithValue("@urunAdi", urunAdi);
                SqlDataAdapter adapter = new SqlDataAdapter(urunleriGetir);
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

    }
}
