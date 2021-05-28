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
    public partial class FormAyrintilar : Form
    {
        public FormAyrintilar()
        {
            InitializeComponent();
        }
        //Burası müşteriyle ilgili kayıt yapıldıktan sonra kayıt ayrıntılarını gösteren sayfadır.
        private void BtnCikis21_Click(object sender, EventArgs e)
        {
            FormYeniMusteri yeni = new FormYeniMusteri();
            yeni.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LblMusteriAd.Text = FormYeniMusteri.MusteriAdSoyad; //FormYeniMusteri class'ı içinde bulunan static değişkeni getiriyor. Bu değişken müşterinin kayıt bilgilerini tutuyor.
            LblMusteriTel.Text = FormYeniMusteri.MusteriTel;
            LblAdres.Text = FormYeniMusteri.MusteriAdres;
            LblMail.Text = FormYeniMusteri.MusteriMail;
            LblTc.Text = FormYeniMusteri.MusteriTC;
            LblOdaNo.Text = FormYeniMusteri.MusteriOdaNo;
            LblOdaTur.Text = FormYeniMusteri.MusteriOdaTur;
            LblGirisTarih.Text = FormYeniMusteri.GirisTarihi;
            LblCikisTarih.Text = FormYeniMusteri.CikisTarihi;
            LblGunSayisi.Text = FormYeniMusteri.GunSayisi;
            LblTutar.Text = FormYeniMusteri.ToplamTutar;
        }
    }
}
