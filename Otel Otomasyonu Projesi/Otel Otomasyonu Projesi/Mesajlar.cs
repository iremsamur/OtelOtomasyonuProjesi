using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Otel_Otomasyonu_Projesi
{
    class Mesajlar
    {
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        public void mesajEkle(string adSoyad,string mesaj)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand yeniMusteriEkle = new SqlCommand("INSERT INTO Table_MusteriMesajlari VALUES(@MusteriAdSoyad,@Mesaj)", baglan.connect);
                yeniMusteriEkle.Parameters.AddWithValue("@MusteriAdSoyad", adSoyad);
                yeniMusteriEkle.Parameters.AddWithValue("@Mesaj", mesaj);

                yeniMusteriEkle.ExecuteNonQuery();
                MessageBox.Show("Mesaj başarıyla eklendi. ", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
        public void musteriMesajBilgiGuncelle(int id, string adSoyad,string mesaj)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand mesajGuncelle = new SqlCommand("UPDATE Table_MusteriMesajlari SET MusteriAdSoyad=@adsoyad,Mesaj=@musteriMesaj WHERE MesajId=@id", baglan.connect);
                mesajGuncelle.Parameters.AddWithValue("@adsoyad", adSoyad);
                mesajGuncelle.Parameters.AddWithValue("@musteriMesaj", mesaj);
               
                mesajGuncelle.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Mesaj başarıyla güncellendi. ", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                mesajGuncelle.ExecuteNonQuery();
                






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
        public void mesajSil(int id)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand mesajSil = new SqlCommand("DELETE Table_MusteriMesajlari WHERE MesajId=@id", baglan.connect);

                mesajSil.Parameters.AddWithValue("@id", id);
                mesajSil.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla silindi. ", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);







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
