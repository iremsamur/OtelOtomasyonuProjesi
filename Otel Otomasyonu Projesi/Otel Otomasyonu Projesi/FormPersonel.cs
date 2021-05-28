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

namespace Otel_Otomasyonu_Projesi
{
    public partial class FormPersonel : Form
    {
        //Personel ile ilgili işlemlerin yapıldığı class
        PersonelIslemleri personelIslem = new PersonelIslemleri();
        AdminGirisi giris = new AdminGirisi();
        private string id;
        private static string girilenMail;
        public string personelId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public static string girilenMailAdres
        {
            get
            {
                return girilenMail;
            }
            set
            {
                girilenMail = value;
            }
        }
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            string yeniPersonelKullaniciAdi = TxtPersonelTC.Text;//Yeni personelin kullanıcı adı tc kimlik numarası olur.
            string yeniPersonelParola = otomatikParolaUretme();
            personelIslem.personelEkle(TxtPersonelAdi.Text, TxtPersonelSoyadi.Text, TxtPersonelTC.Text, yeniPersonelKullaniciAdi, yeniPersonelParola, TxtPersonelMailAdres.Text, MSKPersonelTel.Text, RTBPersonelAdres.Text, TxtPersonelMaas.Text, TxtPersonelUnvan.Text, CBDepartman.Text);
            MessageBox.Show("Aramıza yeni katılan personel" + TxtPersonelAdi.Text + " " + TxtPersonelSoyadi.Text + " 'e atanan geçici kullanıcı adı :  tc kimlik numarası ve geçici parola : " + yeniPersonelParola + " olarak atanmıştır.");
            DGVPersoneller.DataSource = personelIslem.personelleriListele();
        }
        private string otomatikParolaUretme()
        {
            //Sisteme yeni gelen personel için otomatik , güvenli 8 karakterli bir parolanın üretilmesini sağlar.
            Random rastgele = new Random();
            
            string rastgeleParola = "";
            string rastgeleSayi = "";
            string rastgeleBuyukHarf = "";
            string rastgeleKucukHarf = "";
            string rastgeleKarakter = "";
            for(int i = 0; i < 2; i++)
            {
                rastgeleSayi+= rastgele.Next(0, 10).ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                rastgeleBuyukHarf += Convert.ToChar(rastgele.Next(65, 91)).ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                rastgeleKucukHarf += Convert.ToChar(rastgele.Next(97, 123)).ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                rastgeleKarakter += Convert.ToChar(rastgele.Next(33, 47)).ToString();
            }

            rastgeleParola = rastgeleSayi + rastgeleBuyukHarf + rastgeleKarakter + rastgeleKucukHarf;
            string yeniParola = "";
            Random rastgele2 = new Random();
            int randomIndex = 0;
            int uzunluk =rastgeleParola.Length;
            for (int i = uzunluk; i > 0; i--)
            {
                randomIndex = rastgele2.Next(0, uzunluk);
                yeniParola += rastgeleParola[randomIndex];
                rastgeleParola = rastgeleParola.Remove(randomIndex, 1);
                uzunluk = rastgeleParola.Length;
            }
            return yeniParola;
            


        }

        private void BtnPersonelGoster_Click(object sender, EventArgs e)
        {
            DGVPersoneller.DataSource = personelIslem.personelleriListele();
        }

        private void BtnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            int personelIdDegeri = Convert.ToInt32(personelId);
            personelIslem.personelBilgiGuncelle(personelIdDegeri, TxtPersonelAdi.Text, TxtPersonelSoyadi.Text, TxtPersonelTC.Text, TxtPersonelMailAdres.Text, MSKPersonelTel.Text, RTBPersonelAdres.Text, TxtPersonelMaas.Text, TxtPersonelUnvan.Text, CBDepartman.Text);

            DGVPersoneller.DataSource = personelIslem.personelleriListele();
        }

        private void DGVPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            personelId = DGVPersoneller.CurrentRow.Cells[0].Value.ToString();

            TxtPersonelAdi.Text = DGVPersoneller.CurrentRow.Cells[1].Value.ToString();
            TxtPersonelSoyadi.Text = DGVPersoneller.CurrentRow.Cells[2].Value.ToString();
            TxtPersonelTC.Text = DGVPersoneller.CurrentRow.Cells[3].Value.ToString();
            TxtPersonelMailAdres.Text = DGVPersoneller.CurrentRow.Cells[4].Value.ToString();
            MSKPersonelTel.Text = DGVPersoneller.CurrentRow.Cells[5].Value.ToString(); 
            RTBPersonelAdres.Text = DGVPersoneller.CurrentRow.Cells[6].Value.ToString();
            TxtPersonelMaas.Text = DGVPersoneller.CurrentRow.Cells[7].Value.ToString();
            TxtPersonelUnvan.Text = DGVPersoneller.CurrentRow.Cells[8].Value.ToString();
            CBDepartman.Text = DGVPersoneller.CurrentRow.Cells[9].Value.ToString();

            
        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            int personelIdDegeri = Convert.ToInt32(personelId);
            personelIslem.personelBilgiSil(personelIdDegeri);
            DGVPersoneller.DataSource = personelIslem.personelleriListele();
        }

        private void BtnAlanTemizle2_Click(object sender, EventArgs e)
        {
            TxtPersonelAdi.Clear();
            TxtPersonelSoyadi.Clear();
            TxtPersonelTC.Clear();
            TxtPersonelMailAdres.Clear();
            MSKPersonelTel.Clear();
            RTBPersonelAdres.Clear();
            TxtPersonelMaas.Clear();
            TxtPersonelUnvan.Clear();
            CBDepartman.Text = "--Departman Seçiniz--";


        }

        private void BtnAra2_Click(object sender, EventArgs e)
        {
            DGVPersoneller.DataSource = personelIslem.IstenenPersonelleriListele(TxtPersonelAra.Text);
        }

        private void BtnSifreDegisiklik_Click(object sender, EventArgs e)
        {
            FormParolaKullaniciAdiDegisim degisim = new FormParolaKullaniciAdiDegisim();
            bool kontrol = false;
             girilenMailAdres = Interaction.InputBox("Bilgi Girişi", "Şifrenizi veya kullanıcı adınızı değiştirmek için , sistemde kayıtlı olan mail adresinizi giriniz : ", "Örn: diamondHotel@gmail.com ", 0, 0);

            if (girilenMailAdres != null)
            {

                kontrol = giris.mailKontrol(girilenMailAdres);
                if (kontrol == true)
                {
                    MessageBox.Show("Parola Veya Kullanıcı adı değişim işlemi için uygun sayfaya yönlendiriliyorsunuz...", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    degisim.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır!! ", "Error | Otel Otomasyonu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            
        }

        private void BtnCikis12_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            DGVPersoneller.RowHeadersVisible = false;
        }
    }
}
