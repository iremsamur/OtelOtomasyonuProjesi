using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu_Projesi
{
    public partial class YeniSifreEkrani : Form
    {
        AdminGirisi giris = new AdminGirisi();
        //FormAdminGiris adminGirisYap = new FormAdminGiris();
        FormParolaKullaniciAdiDegisim degisim = new FormParolaKullaniciAdiDegisim();


        public YeniSifreEkrani()
        {
            InitializeComponent();



        }

        private void YeniSifreEkrani_Load(object sender, EventArgs e)
        {
            label2Mail.Text = FormAdminGiris.girilenMail;
            //geciciMail = FormAdminGiris.girilenMail;
        }

        private void BtnDegistir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            //MessageBox.Show(FormAdminGiris.girilenMail);
            bool kontrolEt = true;
            bool kontrolEt2 = true;
           
           
           
            
            if (TxtYeniSifre2.Text == null || TxtYeniSifreTekrar2.Text == null)
            {
                MessageBox.Show("Şifre değişimi için lütfen tüm alanları doldurun !!","Uyarı | Otel Otomasyonu",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            
            
            
            else if (TxtYeniSifre2.Text != null && TxtYeniSifreTekrar2.Text != null)
            {
                if (TxtYeniSifre2.Text==TxtYeniSifreTekrar2.Text)
                {
                    kontrolEt2 = degisim.parolaGuvenlikKontrol(TxtYeniSifre2.Text);
                    //MessageBox.Show(kontrolEt2.ToString());
                    if (kontrolEt2 == false)
                    {
                        MessageBox.Show("Belirlediğiniz şifre güvenli bir şifre değil!!", " Hata | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        MessageBox.Show("Güvenli şifre en az 8 haneli olmalıdır !! Ve şifrede en az 1 tane [!@#$%^&*()_+=\\[{\\]};:<>|./?,-] simgeleri , en az 1 tane rakam ,en az 1 tane büyük ve küçük harf bulunmalıdır", "Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                    else
                    {
                        dialog = MessageBox.Show("Şifre değişikliğini onaylıyor musunuz ? ", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (TxtYeniSifre2.Text.Equals(TxtYeniSifreTekrar2.Text))
                        {

                            if (dialog == DialogResult.Yes)
                            {
                                giris.sifreDegistir(TxtYeniSifre2.Text, FormAdminGiris.girilenMail);
                                kontrolEt = giris.bilgilendirmeMailiGonder(FormAdminGiris.girilenMail);
                                if (kontrolEt == true)
                                {
                                    MessageBox.Show("Şifreniz başarıyla değiştirildi . \n Sisteme giriş yapabilirsiniz.", " Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Mail Gönderilemedi", " Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Şifre değilikliği işlemi iptal edilmiştir!!!", " Bilgilendirme | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirlemek istediğiniz şifre ve tekrar girdiğiniz şifre uyumlu değil !! \nLütfen doğru girin .", "Hata | Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            



            }
            
            
        }
    }
}

