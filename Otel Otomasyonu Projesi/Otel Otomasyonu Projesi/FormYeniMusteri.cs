using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Otel_Otomasyonu_Projesi
{
    public partial class FormYeniMusteri : Form
    {
        private static string musteriAdSoyad;
        private static string musteriTel;
        private static string musteriAdres;
        private static string musteriMail;
        private static string musteriTC;
        private static string musteriOdaNo;
        private static string musteriOdaTur;
        private static string girisTarih;
        private static string cikisTarih;
        private static string gunSayi;
        private static string toplamTutar;
        public static string MusteriAdSoyad { 
            get {
                return musteriAdSoyad;
            } 
            set {
                musteriAdSoyad = value;
            } 
        }
        public static string MusteriTel
        {
            get
            {
                return musteriTel;
            }
            set
            {
                musteriTel = value;
            }
        }
        public static string MusteriAdres
        {
            get
            {
                return musteriAdres;
            }
            set
            {
                musteriAdres = value;
            }
        }
        public static string MusteriTC
        {
            get
            {
                return musteriTC;
            }
            set
            {
                musteriTC = value;
            }
        }
        public static string MusteriMail
        {
            get
            {
                return musteriMail;
            }
            set
            {
                musteriMail = value;
            }
        }
        public static string MusteriOdaNo
        {
            get
            {
                return musteriOdaNo;
            }
            set
            {
                musteriOdaNo = value;
            }
        }
       
         public static string MusteriOdaTur
        {
            get
            {
                return musteriOdaTur;
            }
            set
            {
                musteriOdaTur = value;
            }
        }
        public static string GirisTarihi
        {
            get
            {
                return girisTarih;
            }
            set
            {
                girisTarih = value;
            }
        }
        public static string CikisTarihi
        {
            get
            {
                return cikisTarih;
            }
            set
            {
                cikisTarih = value;
            }
        }
        public static string GunSayisi
        {
            get
            {
                return gunSayi;
            }
            set
            {
                gunSayi = value;
            }
        }
        public static string ToplamTutar
        {
            get
            {
                return toplamTutar;
            }
            set
            {
                toplamTutar = value;
            }
        }
        MusteriIslemleri islemler = new MusteriIslemleri();
        private DateTime girisTarihi;
        public  DateTime GirisTarih { 
            get {
                return girisTarihi;
            }
            set {
                girisTarihi = value;
            }
        }
        private DateTime cikisTarihi;
        public DateTime CikisTarih
        {
            get
            {
                return cikisTarihi;
            }
            set
            {
                cikisTarihi = value;
            }
        }
        ArrayList odalar = new ArrayList();
        public FormYeniMusteri()
        {
            InitializeComponent();
            PnlBirinciKat.Visible = false;
            PnlIkinciKat.Visible = false;

        }
        

        
      
        private void BtnSec1_Click(object sender, EventArgs e)
        {
            if (CBBirinciKat.Text == "Göster")
            {
                PnlBirinciKat.Visible = true;
            }
            else if(CBBirinciKat.Text=="Gizle")
            {
                PnlBirinciKat.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız !!");
            }
        }

        private void BtnSec2_Click(object sender, EventArgs e)
        {
            if (CBIkinciKat.Text == "Göster")
            {
                PnlIkinciKat.Visible = true;
            }
            else if(CBIkinciKat.Text=="Gizle")
            {
                PnlIkinciKat.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız !!");
            }
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları göstermektedir!!!!");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları göstermektedir!!!!");
        }
        private void BtnSecili_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sarı renkli butonlar seçili odaları göstermektedir!!!!");
        }

        private void DtpCikisTarih_ValueChanged(object sender, EventArgs e)
        {
            int ucret=0;
            
            DateTime girisTarih = Convert.ToDateTime(DtpGirisTarih.Text);
            DateTime cikisTarih = Convert.ToDateTime(DtpCikisTarih.Text);
            int result = DateTime.Compare(girisTarih, cikisTarih);
            if (result>0 || result==0){
                MessageBox.Show("Otele giriş tarihi çıkış tarihinden daha küçük bir değerde olmalıdır !!!\n Büyük ya da eşit olamaz !!!");

            }
            else
            {
                int birinciKatOdaSayisi = 0, ikinciKatOdaSayisi = 0;
                //oda ücretlendirmesi için oda sayısına bakalım
                for(int i = 0; i < odalar.Count; i++)
                {
                    if(Convert.ToInt32(odalar[i])>=101 && Convert.ToInt32(odalar[i]) <= 109)
                    {
                        birinciKatOdaSayisi++;
                    }
                    else if(Convert.ToInt32(odalar[i]) >= 201 && Convert.ToInt32(odalar[i]) <= 209)
                    {
                        ikinciKatOdaSayisi++;
                    }
                }
                //TimeSpan ile tarihler arasındaki farkı alalım
                TimeSpan sonuc = cikisTarih - girisTarih;
                LblGunSayisi.Text = "Otelde kalınan gün sayısı : \n" + sonuc.TotalDays.ToString();
                TxtGunSayisi.Text = sonuc.TotalDays.ToString();
                ucret = (Convert.ToInt32(sonuc.TotalDays.ToString()) * 500 * birinciKatOdaSayisi)+(Convert.ToInt32(sonuc.TotalDays.ToString()) * 750 * ikinciKatOdaSayisi);
                //Müşteriye seçtiği odalara göre, Otel ücret bilgilerini hesaplar. 
                TxtUcret.Text = ucret.ToString();

    
               


            }
            

        }
     
        public void odaGoster()
        {
            String oda = String.Empty;
            for(int i = 0; i < odalar.Count; i++)
            {
                oda += odalar[i].ToString() + ",";
            }
            if (odalar.Count >= 1)
            {
                oda = oda.Remove(oda.Length - 1, 1);
            }
             TxtOdaNo.Text=oda;
            int birinciKatOdaSayisi = 0, ikinciKatOdaSayisi = 0;
            
            for (int i = 0; i < odalar.Count; i++)
            {
                if (Convert.ToInt32(odalar[i]) >= 101 && Convert.ToInt32(odalar[i]) <= 109)
                {
                    //Müşterinin seçtiği odalardan birinci kat oda sayısını tutar.
                    birinciKatOdaSayisi++;
                }
                else if (Convert.ToInt32(odalar[i]) >= 201 && Convert.ToInt32(odalar[i]) <= 209)
                {
                    //Müşterinin seçtiği odalardan kaç tanesinin ikinci kat oda olduğunu tutar.
                    ikinciKatOdaSayisi++;
                }
            }
            if(birinciKatOdaSayisi!=0 && ikinciKatOdaSayisi != 0)
            {
                TxtOdaTuru.Text = birinciKatOdaSayisi + " adet tek kişilik ve " + ikinciKatOdaSayisi + " adet çift kişilik oda seçildi.";
            }
            else if (birinciKatOdaSayisi != 0 && ikinciKatOdaSayisi == 0)
            {
                TxtOdaTuru.Text = birinciKatOdaSayisi + " adet tek kişilik  oda seçildi.";
            }
            else if (birinciKatOdaSayisi == 0 && ikinciKatOdaSayisi != 0)
            {
                TxtOdaTuru.Text = ikinciKatOdaSayisi + " adet çift kişilik  oda seçildi.";
            }
            else
            {
                TxtOdaTuru.Text = "Henüz oda seçilmedi.";
            }


            

        }
        private void BtnOdaSec(object sender, EventArgs e)
        {
            //Odalar arraylist'i içine müşterinin seçtiği odaların , butonlarının numaraları eklenir.
            if (((Button)sender).BackColor == Color.Lime)//Seçilen oda sarı renkle gösterilir.
            {
                ((Button)sender).BackColor = Color.Yellow;
                if (!odalar.Contains(((Button)sender).Text))
                {
                    //odalar arraylisti içinde tıklanan butonun numarası yoksa dedik
                    odalar.Add(((Button)sender).Text);
                }
                odaGoster();
            }
            else if (((Button)sender).BackColor == Color.Yellow)
            {
                ((Button)sender).BackColor = Color.Lime;
                if (odalar.Contains(((Button)sender).Text))
                {
                    //odalar arraylisti içinde tıklanan butonun numarası yoksa dedik
                    odalar.Remove(((Button)sender).Text);
                }
                odaGoster();
            }
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            FormOtelUcretlendirmeBilgi formBilgi = new FormOtelUcretlendirmeBilgi();
            formBilgi.Show();
        }

        private void BtnAyrintiGoster_Click(object sender, EventArgs e)
        {
            MusteriAdSoyad = TxtMusteriAdi.Text + " " + TxtMusteriSoyadi.Text;
            MusteriTel = MskMusteriTel.Text;
            MusteriAdres = RTBAdres.Text;
            MusteriMail = TxtMusteriMail.Text;
            MusteriTC = TxtMusteriTc.Text;
            MusteriOdaNo = TxtOdaNo.Text;
            MusteriOdaTur = TxtOdaTuru.Text;
            GirisTarihi = DtpGirisTarih.Text;
            CikisTarihi = DtpCikisTarih.Text;
            GunSayisi = TxtGunSayisi.Text;
            ToplamTutar = TxtUcret.Text;
            FormAyrintilar ayrinti = new FormAyrintilar();
            ayrinti.Show();
            this.Hide();
        }

       

       

       

      
        public void odaDurumuKontrol(int odaNumarasi)
        {
            if (odaNumarasi == 101)
            {
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;
            }

            if (odaNumarasi == 102)
            {
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }

            if (odaNumarasi == 103)
            {
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }

            if (odaNumarasi == 104)
            {
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }

            if (odaNumarasi == 105)
            {
                Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;
            }

            if (odaNumarasi == 106)
            {
                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;
            }

            if (odaNumarasi == 107)
            {
                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;
            }

            if (odaNumarasi == 108)
            {
                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }

            if (odaNumarasi == 109)
            {
                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;
            }

            if (odaNumarasi == 201)
            {
                Btn201.BackColor = Color.Red;
                Btn201.Enabled = false;
            }
            if (odaNumarasi == 202)
            {
                Btn202.BackColor = Color.Red;
                Btn202.Enabled = false;
            }
            if (odaNumarasi == 203)
            {
                Btn203.BackColor = Color.Red;
                Btn203.Enabled = false;
            }
            if (odaNumarasi == 204)
            {
                Btn204.BackColor = Color.Red;
                Btn204.Enabled = false;
            }
            if (odaNumarasi == 205)
            {
                Btn205.BackColor = Color.Red;
                Btn205.Enabled = false;
            }
            if (odaNumarasi == 206)
            {
                Btn206.BackColor = Color.Red;
                Btn206.Enabled = false;
            }
            if (odaNumarasi == 207)
            {
                Btn207.BackColor = Color.Red;
                Btn207.Enabled = false;
            }
            if (odaNumarasi == 208)
            {
                Btn208.BackColor = Color.Red;
                Btn208.Enabled = false;
            }
            if (odaNumarasi == 209)
            {
                Btn209.BackColor = Color.Red;
                Btn209.Enabled = false;
            }


        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            GirisTarih = Convert.ToDateTime(DtpGirisTarih.Value);
            CikisTarih = Convert.ToDateTime(DtpCikisTarih.Value);
            int odaNumarasi = 0;
            for (int i = 0; i < odalar.Count; i++)
            {
                odaNumarasi = Convert.ToInt32(odalar[i]);
                islemler.musteriKayitAl(TxtMusteriAdi.Text, TxtMusteriSoyadi.Text, CBCinsiyet.Text, MskMusteriTel.Text, RTBAdres.Text, TxtMusteriMail.Text, TxtMusteriTc.Text, odaNumarasi, TxtUcret.Text, GirisTarih, CikisTarih, TxtOdaTuru.Text);
                odaDurumuKontrol(odaNumarasi);
               
            }
            
          
        }
        
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtMusteriAdi.Text = null;
            TxtMusteriSoyadi.Text = null;
            TxtMusteriMail.Text = null;
            TxtMusteriTc.Text = null;
            TxtOdaNo.Text = null;
            TxtUcret.Text = null;
            MskMusteriTel.Text = null;
            RTBAdres.Text = null;
            TxtGunSayisi.Clear();
            TxtOdaTuru.Clear();
        }
        
        private void FormYeniMusteri_Load(object sender, EventArgs e)
        {
            List<string> yeni = new List<string>();
            yeni = islemler.odaDurumuGetir();
            for(int i = 0; i < yeni.Count; i++)
            {
                odaDurumuKontrol(Convert.ToInt32(yeni[i]));
            }

           

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
