using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Otel_Otomasyonu_Projesi
{
    public partial class FormParolaKullaniciAdiDegisim : Form
    {
        PersonelIslemleri islem = new PersonelIslemleri();
        AdminGirisi giris = new AdminGirisi();
        
        public FormParolaKullaniciAdiDegisim()
        {
            InitializeComponent();
        }

        private void FormParolaKullaniciAdiDegisim_Load(object sender, EventArgs e)
        {
            panelKullaniciAdi.Visible = false;
            panelParola.Visible = false;
        }

        private void checkBoxParola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxParola.Checked == true)
            {
                panelParola.Visible = true;
            }
        }

        private void checkBoxKullaniciAdi_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(FormPersonel.girilenMailAdres);
            if (checkBoxKullaniciAdi.Checked == true)
            {
                panelKullaniciAdi.Visible = true;
            }
        }
     
        public bool parolaGuvenlikKontrol(string parola)
        {
           /*bu metod içinde Regex class'ını kullanarak parolanın güvenlik kontrolünün yapılmasını sağlar. */
            

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            //hasNumber, hasUpperChar,hasLowerChar,hasSymbols karakterlerinden , Buradaki karakterlerden en az 1 tane bulunuyorsa ve hasMiniMaxChar ile 
            //parola en az 8 en çok 15 karakterli ise parolanın güvenli olduğunu yani true döndürür. Bu koşulları sağlamazsa false döndürür.Yani şifre güvensizdir.

            if (!hasLowerChar.IsMatch(parola))
            {
                
                return false;
            }
            else if (!hasUpperChar.IsMatch(parola))
            {
                
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(parola))
            {
                
                return false;
            }
            else if (!hasNumber.IsMatch(parola))
            {
               
                return false;
            }

            else if (!hasSymbols.IsMatch(parola))
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void BtnDegistir_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            string konu = "";
            string icerik = "";
            bool kontrol2 = true;
            
            //Hem parola hem kullanıcı adı değiştirmek için, iki check box da işaretli ise:
            if(checkBoxKullaniciAdi.Checked == true && checkBoxParola.Checked == true)
            {
                if(TxtYeniParola.Text!=null && TxtYeniParolaTekrar.Text!=null && TxtYeniKullaniciAdi.Text != null)
                {
                   
                    if (TxtYeniParola.Text.Equals(TxtYeniParolaTekrar.Text))//Yeni parola ve yeniparolatekrar'da aynı değerin girilip girilmediğini kontrol eder.
                    {
                        kontrol = parolaGuvenlikKontrol(TxtYeniParola.Text);//girilen parolanın güvenli olup olmadığını kontrol eder.
                        if (kontrol == true)
                        {
                            MessageBox.Show("Güvenli parola oluşturuldu .");
                            if (islem.kullaniciAdiKontrol(TxtYeniKullaniciAdi.Text) == true)//Sistemde kullanıcının kaydetmek istediği yeni kullanıcı adının olup olmadığının kontrolü yapılır
                            {
                                islem.personelParolaKullaniciAdiGuncelle(FormPersonel.girilenMailAdres, TxtYeniKullaniciAdi.Text, TxtYeniParola.Text);
                                konu = "Parola Ve Kullanıcı Adı Değişikliği Bildirimi ";
                                icerik = "Kullanıcı adı ve parolanız isteğiniz üzerine başarıyla değiştirilmiştir. Eğer bu değişiklik size ait değilse , bizimle iletişime geçiniz!!";
                                kontrol2= giris.bilgilendirmeMailiGonder(FormPersonel.girilenMailAdres,konu,icerik);//Parola-kullanıcı adı değişikliğinin yapıldığına dair kullanıcıya bilgilendirme maili gönderir
                                if (kontrol2 == true)
                                {
                                    MessageBox.Show("Değişiklikler başarıyla kaydedildi.");
                                }
                                else
                                {
                                    MessageBox.Show("Değişiklikler başarıyla kaydedilemedi !! Bir hata oluştu!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı adı zaten sistemde kayıtlı bulunmaktadır!!!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oluşturulan parola yeterince güvenli değil!! Lütfen daha güvenli bir parola giriniz !!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lütfen yeni parolanızı tekrarıyla birlikte uyumlu girin !!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Değişiklikler için tüm alanlar doldurulmalıdır!!","Bilgilendirme",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                }
                
            }
            else if(checkBoxKullaniciAdi.Checked == true && checkBoxParola.Checked == false)
            //Sadece kullanıcı adı değiştirmek için, kullanıcı adı check box'ı  işaretli ise:
            {

                if (TxtYeniKullaniciAdi.Text != null)
                {
                    if (islem.kullaniciAdiKontrol(TxtYeniKullaniciAdi.Text) == true)
                    {
                        
                        islem.personelKullaniciAdiGuncelle(FormPersonel.girilenMailAdres, TxtYeniKullaniciAdi.Text);
                        konu = "Kullanıcı Adı Değişikliği Bildirimi ";
                        icerik = "Kullanıcı adınız isteğiniz üzerine başarıyla değiştirilmiştir. Eğer bu değişiklik size ait değilse , bizimle iletişime geçiniz!!";
                        kontrol2 = giris.bilgilendirmeMailiGonder(FormPersonel.girilenMailAdres, konu, icerik);
                        if (kontrol2 == true)
                        {
                            MessageBox.Show("Değişiklikler başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Değişiklikler başarıyla kaydedilemedi !! Bir hata oluştu!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten sistemde kayıtlı bulunmaktadır!!!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Değişiklikler için tüm alanlar doldurulmalıdır!!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
            else if(checkBoxKullaniciAdi.Checked == false && checkBoxParola.Checked == true)  //Sadece parola değiştirmek için, parola check box'ı  işaretli ise:
            {
                if (TxtYeniParola.Text != null && TxtYeniParolaTekrar.Text != null )
                {

                    if (TxtYeniParola.Text.Equals(TxtYeniParolaTekrar.Text))
                    {
                        kontrol = parolaGuvenlikKontrol(TxtYeniParola.Text);
                        if (kontrol == true)
                        {
                            MessageBox.Show("Güvenli parola oluşturuldu .");
                            if (islem.kullaniciAdiKontrol(TxtYeniKullaniciAdi.Text) == true)
                            {
                                islem.personelParolaGuncelle(FormPersonel.girilenMailAdres,  TxtYeniParola.Text);
                                konu = "Parola  Değişikliği Bildirimi ";
                                icerik = "Parolanız isteğiniz üzerine başarıyla değiştirilmiştir. Eğer bu değişiklik size ait değilse , bizimle iletişime geçiniz!!";
                                kontrol2 = giris.bilgilendirmeMailiGonder(FormPersonel.girilenMailAdres, konu, icerik);
                                if (kontrol2 == true)
                                {
                                    MessageBox.Show("Değişiklikler başarıyla kaydedildi.");
                                }
                                else
                                {
                                    MessageBox.Show("Değişiklikler başarıyla kaydedilemedi !! Bir hata oluştu!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bu kullanıcı adı zaten sistemde kayıtlı bulunmaktadır!!!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oluşturulan parola yeterince güvenli değil!! Lütfen daha güvenli bir parola giriniz !!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lütfen yeni parolanızı tekrarıyla birlikte uyumlu girin !!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Değişiklikler için tüm alanlar doldurulmalıdır!!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnCikis11_Click(object sender, EventArgs e)
        {
            FormPersonel personel = new FormPersonel();
            personel.Show();
            this.Hide();
        }
    }
}
