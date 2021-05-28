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
    class PersonelIslemleri
    {
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        public void personelEkle(string personelAdi, string personelSoyadi, string personelTc,string personelKullaniciAdi,string personelParola, string personelMail, string personelTel, string personelAdres,string personelMaas,string personelUnvan,string departman)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO Table_PersonelBilgileri VALUES(@PersonelAdi,@PersonelSoyadi,@PersonelTC,@PersonelKullaniciAdi,@PersonelParola,@PersonelMail,@PersonelGirisTarih,@PersonelTel,@PersonelAdres,@PersonelMaas,@PersonelUnvan,@Departman)", baglan.connect);
                ekle.Parameters.AddWithValue("@PersonelAdi", personelAdi);
                ekle.Parameters.AddWithValue("@PersonelSoyadi", personelSoyadi);
                ekle.Parameters.AddWithValue("@PersonelTC", personelTc);
                ekle.Parameters.AddWithValue("@PersonelKullaniciAdi", personelKullaniciAdi);
                ekle.Parameters.AddWithValue("@PersonelParola", personelParola);
                ekle.Parameters.AddWithValue("@PersonelMail", personelMail);
                ekle.Parameters.AddWithValue("@PersonelGirisTarih", DateTime.Now);
                ekle.Parameters.AddWithValue("@PersonelTel", personelTel);
                ekle.Parameters.AddWithValue("@PersonelAdres", personelAdres);
                ekle.Parameters.AddWithValue("@PersonelMaas", personelMaas);
                ekle.Parameters.AddWithValue("@PersonelUnvan", personelUnvan);
                ekle.Parameters.AddWithValue("@Departman", departman);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Yeni personel başarıyla eklendi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);



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
        public DataTable personelleriListele()
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelGetir = new SqlCommand("SELECT PersonelId,PersonelAdi,PersonelSoyadi,PersonelTC,PersonelMail,PersonelTel,PersonelAdres,PersonelMaas,PersonelUnvan,Departman FROM Table_PersonelBilgileri", baglan.connect);
                SqlDataAdapter adapter = new SqlDataAdapter(personelGetir);
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

        public void personelBilgiGuncelle(int id,string personelAdi, string personelSoyadi, string personelTc,  string personelMail, string personelTel, string personelAdres, string personelMaas, string personelUnvan, string departman)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelGuncelle = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelAdi=@personelAdi,PersonelSoyadi=@personelSoyadi,PersonelTC=@personelTC,PersonelMail=@personelMail,PersonelTel=@personelTel,PersonelAdres=@personelAdres,PersonelMaas=@personelMaas,PersonelUnvan=@personelUnvan,Departman=@departman WHERE PersonelId=@id", baglan.connect);
                personelGuncelle.Parameters.AddWithValue("@personelAdi", personelAdi);
                personelGuncelle.Parameters.AddWithValue("@personelSoyadi",personelSoyadi);
                personelGuncelle.Parameters.AddWithValue("@personelTC", personelTc);
              
                personelGuncelle.Parameters.AddWithValue("@personelMail", personelMail);
                personelGuncelle.Parameters.AddWithValue("@personelTel", personelTel);
                personelGuncelle.Parameters.AddWithValue("@personelAdres", personelAdres);
                personelGuncelle.Parameters.AddWithValue("@personelMaas", personelMaas);
                personelGuncelle.Parameters.AddWithValue("@personelUnvan", personelUnvan);
                personelGuncelle.Parameters.AddWithValue("@departman", departman);
                personelGuncelle.Parameters.AddWithValue("@id", id);
                personelGuncelle.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla güncellendi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public void personelBilgiSil(int id)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelSil = new SqlCommand("DELETE Table_PersonelBilgileri WHERE PersonelId=@id", baglan.connect);

                personelSil.Parameters.AddWithValue("@id", id);
                personelSil.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla silindi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        
        public DataTable IstenenPersonelleriListele(string personelTc)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelleriGetir = new SqlCommand("SELECT * FROM Table_PersonelBilgileri WHERE PersonelTC=@personelTC", baglan.connect);
                personelleriGetir.Parameters.AddWithValue("@personelTC", personelTc);
                SqlDataAdapter adapter = new SqlDataAdapter(personelleriGetir);
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
        public void personelParolaKullaniciAdiGuncelle(string mailAdres, string kullaniciAdi, string parola)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelGuncelle = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelKullaniciAdi=@personelKullaniciAdi,PersonelParola=@personelParola WHERE PersonelMail=@personelMail", baglan.connect);
                personelGuncelle.Parameters.AddWithValue("@personelKullaniciAdi", kullaniciAdi);
                personelGuncelle.Parameters.AddWithValue("@personelParola", parola);
                personelGuncelle.Parameters.AddWithValue("@personelMail", mailAdres);

                personelGuncelle.ExecuteNonQuery();
                MessageBox.Show("Değişiklikler  başarıyla kaydedildi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public void personelParolaGuncelle(string mailAdres,  string parola)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelGuncelle = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelParola=@personelParola WHERE PersonelMail=@personelMail", baglan.connect);
                
                personelGuncelle.Parameters.AddWithValue("@personelParola", parola);
                personelGuncelle.Parameters.AddWithValue("@personelMail", mailAdres);

                personelGuncelle.ExecuteNonQuery();
                MessageBox.Show("Değişiklikler  başarıyla kaydedildi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public void personelKullaniciAdiGuncelle(string mailAdres, string kullaniciAdi)
        {
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand personelGuncelle = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelKullaniciAdi=@personelKullaniciAdi WHERE PersonelMail=@personelMail", baglan.connect);
                personelGuncelle.Parameters.AddWithValue("@personelKullaniciAdi", kullaniciAdi);
               
                personelGuncelle.Parameters.AddWithValue("@personelMail", mailAdres);

                personelGuncelle.ExecuteNonQuery();
                MessageBox.Show("Değişiklikler  başarıyla kaydedildi . ", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);






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
        public bool kullaniciAdiKontrol(string kullaniciAdi)
        {
            int sayac = 0;
            bool kontrolDurumu = false;
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();

            }
            try
            {
                baglan.connect.Open();
                SqlCommand kontrol = new SqlCommand("SELECT * FROM Table_PersonelBilgileri WHERE PersonelKullaniciAdi=@kullaniciAdi", baglan.connect);
                kontrol.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                SqlDataReader reader = kontrol.ExecuteReader();
                while (reader.Read())
                {
                    sayac++ ;
                }
                if (sayac != 0)
                {
                    kontrolDurumu=false;
                }
                else
                {
                    kontrolDurumu = true;
                }
                return kontrolDurumu;





            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
                return false;

            }
            finally
            {
                baglan.connect.Close();
            }

        }

    }
}
