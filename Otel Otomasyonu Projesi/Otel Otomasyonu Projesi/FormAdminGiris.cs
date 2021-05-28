using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Otel_Otomasyonu_Projesi
{
    public partial class FormAdminGiris : Form
    {
        
        private static string mail;
        public static string girilenMail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }

        Admin admin = new Admin();
        AdminGirisi adminGiris = new AdminGirisi();
        FormAnaSayfa anaSayfa = new FormAnaSayfa();
        YeniSifreEkrani yeniSifre = new YeniSifreEkrani();
   
        public FormAdminGiris()
        {
            InitializeComponent();

        }

        

       
        

       
        //şifre unutma durumunda , şifre değiştirmek için butonu çalıştıracak fonksiyon
        private void BtnSifreUnutma_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            girilenMail = Interaction.InputBox("Bilgi Girişi", "Şifrenizi değiştirmek için , sistemde kayıtlı olan mail adresinizi giriniz : ", "Örn: diamondHotel@gmail.com ", 0, 0);

            if (girilenMail != null)
            {
                MessageBox.Show("Girilen Mail :  " + girilenMail);
                kontrol = adminGiris.mailKontrol(girilenMail);
                if (kontrol == true)
                {
                    yeniSifre.Show();

                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır!! ", "Error | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        //Giriş yapmayı sağlayacak butonu çalıştıran metod
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == String.Empty || TxtParola.Text == String.Empty)
            {
                MessageBox.Show("Sisteme giriş yapabilmek için lütfen tüm alanları doldurunuz !!", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                bool kontrol = adminGiris.girisYap(TxtKullaniciAdi.Text, TxtParola.Text, DateTime.Now);
                //string kullaniciGirisBilgisi = TxtKullaniciAdi.Text + " " + TxtParola.Text;
                //Console.WriteLine("kullaniciGirisBilgisi"+kullaniciGirisBilgisi);
                //Console.WriteLine("AdminGirisdurumu" + AdminGirisi.AdminGirisKontrol);
                if (kontrol == true)
                {
                    MessageBox.Show("Giriş Başarılı.\nAna ekrana yönlendiriliyorsunuz...");
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız. \n Lütfen tekrar deneyin ", "Error | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtKullaniciAdi.Text = null;
            TxtParola.Text = null;
        }

        private void BtnCikis4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnKullaniciAdiUnuttum_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            bool kontrol2 = false;
            string konu = "";
            string icerik = "";
            string girilenMailAdres = Interaction.InputBox("Bilgi Girişi", "Kullanıcı Adınızı resetlemek için , sistemde kayıtlı olan mail adresini giriniz : ", "Örn: diamondHotel@gmail.com ", 0, 0);
            konu = "Kullanıcı Adının Değiştirilmesi";
            icerik = "Kullanıcı adınızı unuttuğunu bildirmeniz talebiyle kullanıcı adınız değiştirilmiştir. Bu işlem size ait değilse, lütfen bizimle iletişime geçiniz !";
            if (girilenMailAdres != null)
            {
                MessageBox.Show("Girilen Mail :  " + girilenMailAdres);
                kontrol = adminGiris.mailKontrol(girilenMailAdres);
                if (kontrol == true)
                {
                    adminGiris.kullaniciAdiDegistir(girilenMailAdres);//kullanıcı adı değişimini sağlayacak metodu çağırıyor.
                    kontrol2=adminGiris.bilgilendirmeMailiGonder(girilenMailAdres, konu, icerik);//burada da kullanıcıya kullanıcı adının değiştirildiğine dair mail gönderecek metodu çağırıyor.
                    if (kontrol2 == true)
                    {
                        MessageBox.Show("Kullanıcı adınız geçici olarak mail adresiniz olarak atanmıştır. Sisteme mail Adresinizle giriş yaparak , kullanıcı adınızı değiştirebilirsiniz", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bir sorun oluştu. Lütfen tekrar deneyin !!", "Hata | Otel Otomasyonu ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    

                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır!! ", "Error | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
    }
}
