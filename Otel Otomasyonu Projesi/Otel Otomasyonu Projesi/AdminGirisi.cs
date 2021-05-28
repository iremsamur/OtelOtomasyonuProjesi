using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;


namespace Otel_Otomasyonu_Projesi
{
    class AdminGirisi
    {
        private static string adminGirisDurum;
        VeritabaniBaglanti baglanti = new VeritabaniBaglanti();
        Admin admin = new Admin();
        public AdminGirisi()
        {

        }
        public static string AdminGirisKontrol
        {
            get
            {
                return adminGirisDurum;
            }
            set
            {
                adminGirisDurum = value;
            }
        }
        public bool girisYap(string adminKullaniciAdi, string adminParola, DateTime girisTarihi)
        {
            bool girisKontrol = true;
            int sayac = 0;
            if (baglanti.connect.State == System.Data.ConnectionState.Open)
            {
                baglanti.connect.Close();
            }
            try
            {
                baglanti.connect.Open();
                SqlCommand girisKullaniciAdi = new SqlCommand("SELECT PersonelKullaniciAdi FROM Table_PersonelBilgileri WHERE PersonelKullaniciAdi=@kullaniciAdi", baglanti.connect);
                girisKullaniciAdi.Parameters.AddWithValue("@kullaniciAdi", adminKullaniciAdi);
                SqlDataReader kullaniciAdiOku = girisKullaniciAdi.ExecuteReader();
                if (kullaniciAdiOku.Read())
                {
                    admin.AdminKullaniciAdi = kullaniciAdiOku["PersonelKullaniciAdi"].ToString();
                    SqlCommand girisKullaniciParola = new SqlCommand("SELECT PersonelParola FROM Table_PersonelBilgileri WHERE PersonelParola=@kullaniciParola", baglanti.connect);
                    girisKullaniciParola.Parameters.AddWithValue("@kullaniciParola", adminParola);
                    SqlDataReader kullaniciParolaOku = girisKullaniciParola.ExecuteReader();
                    if (kullaniciParolaOku.Read())
                    {
                        admin.AdminParola = kullaniciParolaOku["PersonelParola"].ToString();
                        sayac++;
                        
                        SqlCommand girisTarihGuncelle = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelGirisTarih=@girisTarih WHERE PersonelKullaniciAdi=@kullaniciAd AND PersonelParola=@kullaniciSifre", baglanti.connect);
                        girisTarihGuncelle.Parameters.AddWithValue("@girisTarih", girisTarihi);
                        girisTarihGuncelle.Parameters.AddWithValue("@kullaniciAd", admin.AdminKullaniciAdi);
                        girisTarihGuncelle.Parameters.AddWithValue("@kullaniciSifre", admin.AdminParola);
                        girisTarihGuncelle.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Parola hatalı!!", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı hatalı!!!!", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                if (sayac != 0)
                {
                    girisKontrol = true;
                }
                else
                {
                    girisKontrol = false;

                }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi !!" + hata.Message);
                girisKontrol = false;
                
            }
            finally
            {
                baglanti.connect.Close();
            }
            return girisKontrol;


        }
        public bool mailKontrol(string mailAdresi)
        {
            int sayac = 0;
            bool kontrol = true;
            if (baglanti.connect.State == System.Data.ConnectionState.Open)
            {
                baglanti.connect.Close();
            }
            try
            {
                baglanti.connect.Open();
                SqlCommand mailKontrol = new SqlCommand("SELECT PersonelMail FROM Table_PersonelBilgileri WHERE PersonelMail=@adminMailAdres", baglanti.connect);
                mailKontrol.Parameters.AddWithValue("@adminMailAdres", mailAdresi);
                SqlDataReader adminMailOku = mailKontrol.ExecuteReader();
                if (adminMailOku.Read())
                {
                    sayac++;
                }
                if (sayac != 0)
                {
                    kontrol = true;
                }
                else
                {
                    kontrol = false;
                }

            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata meydana geldi !!" + hata.Message);
                kontrol = false;
            }
            finally
            {
                baglanti.connect.Close();
            }
            return kontrol;


        }
        public void sifreDegistir(string yeniSifre,string Mail)
        {
            try
            {
                baglanti.connect.Open();
                SqlCommand sifredegisiklik = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelParola=@adminSifre WHERE PersonelMail=@mailAdresi", baglanti.connect);
                sifredegisiklik.Parameters.AddWithValue("@adminSifre", yeniSifre);
                sifredegisiklik.Parameters.AddWithValue("@mailAdresi", Mail);
               
                sifredegisiklik.ExecuteNonQuery();
                MessageBox.Show("Şifre başarıyla değişti");
            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata meydana geldi !!" + hata.Message);
            }
            finally
            {
                baglanti.connect.Close();
            }
        }
        public void kullaniciAdiDegistir(string mail)
        {
            try
            {
                baglanti.connect.Open();
                SqlCommand sifredegisiklik = new SqlCommand("UPDATE Table_PersonelBilgileri SET PersonelKullaniciAdi=@geciciKullaniciAdi WHERE PersonelMail=@mailAdresi", baglanti.connect);
                sifredegisiklik.Parameters.AddWithValue("@geciciKullaniciAdi",mail);
                sifredegisiklik.Parameters.AddWithValue("@mailAdresi", mail);

                sifredegisiklik.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı adı başarıyla değişti");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi !!" + hata.Message);
            }
            finally
            {
                baglanti.connect.Close();
            }
        }
        public bool bilgilendirmeMailiGonder(string mail)
        {

            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("otelotomasyonu3@gmail.com");
            //
            ePosta.To.Add(mail);
            
            //
            ePosta.Attachments.Add(new Attachment(@"C:\Users\İREM SAMUR\Desktop\c#applications\OtelOtomasyonu\pictures\blueDiamond.jpg"));
            //
            ePosta.Subject = "BİLGİLENDİRME MAİLİ - Şifre değişikliği";
            //
            ePosta.Body = "Şifrenizi unutmanız talebiyle belirlediğiniz yeni şifreyle sistemde şifre değişiminizin başarıyla gerçekleştirildiğini bilginize sunarız .Eğer bu siz değilseniz lütfen bizimle iletişime geçiniz .Diamond Hotel Yönetim Sistemi";
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("otelotomasyonu3@gmail.com", "dmn1239AB");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }
        public bool bilgilendirmeMailiGonder(string mail,string konu,string icerik)
        {

            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("otelotomasyonu3@gmail.com");
            //
            ePosta.To.Add(mail);

            //
            ePosta.Attachments.Add(new Attachment(@"C:\Users\İREM SAMUR\Desktop\c#applications\OtelOtomasyonu\pictures\blueDiamond.jpg"));
            //
            ePosta.Subject = konu;
            //
            ePosta.Body = icerik;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("otelotomasyonu3@gmail.com", "dmn1239AB");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }






    }
}
