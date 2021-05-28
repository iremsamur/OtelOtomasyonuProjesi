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
    public partial class FormGelirGider : Form
    {
        GelirGiderIslemleri islem = new GelirGiderIslemleri();
        private bool kontrol = false;
        private static double musteriKazanc;
        private static double personelMaas;
        private static double urunToplam;
        private static double faturaToplam;
        public static double MusteriKazanc
        {
            get
            {
                return musteriKazanc;
            }
            set
            {
                musteriKazanc = value;
            }
        }
        public static double PersonelMaas
        {
            get
            {
                return personelMaas;
            }
            set
            {
                personelMaas = value;
            }
        }
        public static double UrunToplam
        {
            get
            {
                return urunToplam;
            }
            set
            {
                urunToplam = value;
            }
        }
        public static double FaturaToplam
        {
            get
            {
                return faturaToplam;
            }
            set
            {
                faturaToplam = value;
            }
        }
        public FormGelirGider()
        {
            InitializeComponent();
        }

        private void FormGelirGider_Load(object sender, EventArgs e)
        {
            PnlGelirGider.Visible = false;
            lblBaslik.Text = DateTime.Now.ToString() + " Tarihli Gelir- Gider Durumu";
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //GelirGiderIslemleri class'ından oluşturduğum islem nesnesiyle müşterilerden elde edilen toplam gelirler,
            //personel maaş giderleri, mutfak-oda ürün giderleri , fatura giderleri hesaplamalarını yaptırarak otelin toplam gelir giderlerini hesaplattırıp sonucu ekrana
            //yazmasını sağlar.
            LblToplamKasa.Text = islem.musteriGelirHesapla().ToString();
            LblPersonelMaas.Text = islem.personelMaasGiderHesapla().ToString();
            LblUrunToplam.Text = (islem.mutfakUrunleriGiderHesapla() + islem.odaUrunleriGiderHesapla()).ToString();
            LblFaturaToplam.Text = islem.faturaGiderHesapla().ToString();
            musteriKazanc = 0; personelMaas = 0; urunToplam = 0; faturaToplam=0;
            musteriKazanc = Convert.ToDouble(LblToplamKasa.Text);
            personelMaas = Convert.ToDouble(LblPersonelMaas.Text);
            urunToplam = Convert.ToDouble(LblUrunToplam.Text);
            faturaToplam = Convert.ToDouble(LblFaturaToplam.Text);


            LblSonuc.Text =( musteriKazanc - (personelMaas + urunToplam + faturaToplam)).ToString();
            kontrol = true;

                
               
                
            
            
        }

        private void BtnFatura_Click(object sender, EventArgs e)
        {
           
                FormFaturalar fatura = new FormFaturalar();
                fatura.Show();
                this.Hide();
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*gelir-gider durumuna göre kar- zarar durumunu hesaplayıp, bildirimini yapar.*/
            musteriKazanc = 0; personelMaas = 0; urunToplam = 0; faturaToplam = 0;
            double gelirtutar=0,giderTutar=0;
            musteriKazanc = Convert.ToDouble(LblToplamKasa.Text);
            personelMaas = Convert.ToDouble(LblPersonelMaas.Text);
            urunToplam = Convert.ToDouble(LblUrunToplam.Text);
            faturaToplam = Convert.ToDouble(LblFaturaToplam.Text);
            PnlGelirGider.Visible = true;
            LblKarOran.Text = (((musteriKazanc - (personelMaas + urunToplam + faturaToplam)) * 100) / (personelMaas + urunToplam + faturaToplam)).ToString();
            LblKar.Text = "% " + LblKarOran.Text;
            LblGelirTutar.Text = musteriKazanc.ToString();
            LblGiderTutar.Text = (personelMaas + urunToplam + faturaToplam).ToString();
            gelirtutar = Convert.ToDouble(LblGelirTutar.Text);
            giderTutar = Convert.ToDouble(LblGiderTutar.Text);
            
            if (gelirtutar > giderTutar)
            {
                PnlGelirGider.BackColor = Color.Green;
                MessageBox.Show("Bu ay "+LblSonuc.Text + "TL kardasınız ", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (gelirtutar < giderTutar)
            {
                PnlGelirGider.BackColor = Color.Red;
                MessageBox.Show("Bu ay "+LblSonuc.Text + "TL zarardasınız ", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                PnlGelirGider.BackColor = Color.White;
                MessageBox.Show("Bu ay " + LblSonuc.Text + "TL , ne kadar ne zarardasınız  ", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }

        }

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            //Hesapla butonuna tıklayıp,hesaplama yaptırıldıktan sonra verileri göster ile gelir-gider ve harcamaların istatistiksel verilerini gösterir.
            if (kontrol == true)
            {
                FormIstatistikselVeriler istatistik = new FormIstatistikselVeriler();
                istatistik.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen öncelikle gelir - gider hesaplama işlemini , hesaplama butonuna tıklayarak gerçekleştiriniz !!", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }

        private void BtnCikis7_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
