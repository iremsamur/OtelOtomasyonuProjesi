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
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        //Burada ilgili butonlarla bulunduğumuz ana sayfadan diğer sayfalara geçiş yapmayı sağlar.
        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FormAdminGiris adminGiris = new FormAdminGiris();
            adminGiris.Show();
            this.Hide();
        }

        private void BtnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            FormYeniMusteri yeniMusteri = new FormYeniMusteri();
            yeniMusteri.Show();
            this.Hide();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FormOdalar odalar = new FormOdalar();
            odalar.Show();
            this.Hide();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FormMusteriler musteri = new FormMusteriler();
            musteri.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Burada timer kullanarak , güncel tarih ve saati sürekli ekranda göstermesini sağladım.
            labelTarih.Text = DateTime.Now.ToLongDateString();
            labelZaman.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGelirGider_Click(object sender, EventArgs e)
        {
            FormGelirGider gelirGider = new FormGelirGider();
            gelirGider.Show();
            this.Hide();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FormStok stok = new FormStok();
            stok.Show();
            this.Hide();
        }

        private void BtnPersonelIslem_Click(object sender, EventArgs e)
        {
            FormPersonel personel = new FormPersonel();
            personel.Show();
            this.Hide();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FormRadyoDinle dinle = new FormRadyoDinle();
            dinle.Show();
            this.Hide();
        }

        private void BtnGazete_Click(object sender, EventArgs e)
        {
            FormGazeteler gazete = new FormGazeteler();
            gazete.Show();
            this.Hide();
        }

        private void BtnMesaj_Click(object sender, EventArgs e)
        {
            FormMesajlar mesaj = new FormMesajlar();
            mesaj.Show();
            this.Hide();
        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            FormHakkimizda hakkimizda = new FormHakkimizda();
            hakkimizda.Show();
            this.Hide();
        }

        private void BtnHavaDurumu_Click(object sender, EventArgs e)
        {
            FormHavaDurumu havaDurum = new FormHavaDurumu();
            havaDurum.Show();
            this.Hide();
        }
    }
}
