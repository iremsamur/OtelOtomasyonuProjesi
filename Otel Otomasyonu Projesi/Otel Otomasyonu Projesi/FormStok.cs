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
    public partial class FormStok : Form
    {
        //Otele alınan mutfak ve oda ürünlerinin stok olarak eklenmesini - bu ürünlerle ilgili güncelleme,silme gibi işlemlerin yapılmasını sağlar.
        MutfakUrunIslemleri mutfakIslem = new MutfakUrunIslemleri();
        OdaUrunIslemleri odaIslem = new OdaUrunIslemleri();
        private string id;
        public string Id
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
        public FormStok()
        {
            InitializeComponent();
        }
        //Radio Button da mutfak radio button seçili ise mutfak ürünlerine göre işlemleri gerçekleştirir. Eğer oda radio button ı seçili ise oda ürünlerine göre işlem gerçekleştirir.
        private void RBtnMutfak_CheckedChanged(object sender, EventArgs e)
        {
            DGVUrunler.DataSource = null;
            if (RBtnMutfak.Checked == true)
            {
                DGVUrunler.DataSource = mutfakIslem.mutfakUrunleriListele();
            }
            CBKategori.Items.Clear();
            mutfakIslem.mutfakKategoriGetir();
            for(int i = 0; i < mutfakIslem.kategoriler.Count; i++)
            {
                CBKategori.Items.Add(mutfakIslem.kategoriler[i].ToString());//mutfak ürünleri kategorilerini combo box içine yazar.
            }
        }

        private void RBtnOda_CheckedChanged(object sender, EventArgs e)
        {
            DGVUrunler.DataSource = null;
            if (RBtnOda.Checked == true)
            {
                DGVUrunler.DataSource = odaIslem.odaUrunleriListele();
            }
            CBKategori.Items.Clear();
            odaIslem.odaKategoriGetir();
            for (int i = 0; i < odaIslem.kategoriler2.Count; i++)
            {
                CBKategori.Items.Add(odaIslem.kategoriler2[i].ToString());
            }
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            if(RBtnMutfak.Checked == true)
            {
                DateTime gelisTarih = Convert.ToDateTime(DTPGelisTarih.Value);
                mutfakIslem.mutfakUrunEkle(TxtUrunAdi.Text, CBKategori.Text, TxtUrunAdet.Text, TxtUrunFiyat.Text, TxtFirmaAdi.Text, gelisTarih);
                DGVUrunler.DataSource = mutfakIslem.mutfakUrunleriListele();
            }
            if (RBtnOda.Checked == true)
            {
                DateTime gelisTarih = Convert.ToDateTime(DTPGelisTarih.Value);
                odaIslem.odaUrunEkle(TxtUrunAdi.Text, CBKategori.Text, TxtUrunAdet.Text, TxtUrunFiyat.Text, TxtFirmaAdi.Text, gelisTarih);
                DGVUrunler.DataSource = odaIslem.odaUrunleriListele();
            }
           
        }

        private void BtnUrunGoster_Click(object sender, EventArgs e)
        {
            if (RBtnOda.Checked == true)
            {
                DGVUrunler.DataSource = odaIslem.odaUrunleriListele();
            }
            if (RBtnMutfak.Checked == true)
            {
                DGVUrunler.DataSource = mutfakIslem.mutfakUrunleriListele();
            }
        }
        
        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(Id);
            
            if (RBtnMutfak.Checked == true)
            {
                DateTime gelisTarih = Convert.ToDateTime(DTPGelisTarih.Value);
                mutfakIslem.mutfakUrunBilgiGuncelle(urunId,TxtUrunAdi.Text, CBKategori.Text, TxtUrunAdet.Text, TxtUrunFiyat.Text, TxtFirmaAdi.Text, gelisTarih);
                DGVUrunler.DataSource = mutfakIslem.mutfakUrunleriListele();

            }
            if (RBtnOda.Checked == true)
            {
                DateTime gelisTarih = Convert.ToDateTime(DTPGelisTarih.Value);
                
                odaIslem.odaUrunBilgiGuncelle(urunId,TxtUrunAdi.Text, CBKategori.Text, TxtUrunAdet.Text, TxtUrunFiyat.Text, TxtFirmaAdi.Text, gelisTarih);
                DGVUrunler.DataSource = odaIslem.odaUrunleriListele();
            }
        }

        private void DGVUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //LblUrunId.Text = DGVUrunler.CurrentRow.Cells[0].Value.ToString();
            Id  = DGVUrunler.CurrentRow.Cells[0].Value.ToString();

            TxtUrunAdi.Text = DGVUrunler.CurrentRow.Cells[1].Value.ToString();
           
            CBKategori.Text = DGVUrunler.CurrentRow.Cells[2].Value.ToString();
            TxtUrunAdet.Text = DGVUrunler.CurrentRow.Cells[3].Value.ToString();
            TxtUrunFiyat.Text = DGVUrunler.CurrentRow.Cells[4].Value.ToString();
            TxtFirmaAdi.Text = DGVUrunler.CurrentRow.Cells[5].Value.ToString();
            DTPGelisTarih.Value = Convert.ToDateTime(DGVUrunler.CurrentRow.Cells[6].Value.ToString());
      



        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(Id);
            if (RBtnMutfak.Checked == true)
            {

                mutfakIslem.mutfakUrunBilgiSil(urunId);
                DGVUrunler.DataSource = mutfakIslem.mutfakUrunleriListele();
            }
            if (RBtnOda.Checked == true)
            {
                odaIslem.odaUrunBilgiSil(urunId);
                DGVUrunler.DataSource = odaIslem.odaUrunleriListele();
            }
        }

        private void BtnAlanTemizle_Click(object sender, EventArgs e)
        {
            TxtUrunAdi.Clear();
            CBKategori.Text = null;
            TxtUrunAdi.Clear();
            TxtUrunAdet.Clear();
            TxtUrunFiyat.Clear();
            TxtFirmaAdi.Clear();
            DTPGelisTarih.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string urunAdi = TxtUrunAra.Text;
            if (RBtnMutfak.Checked == true)
            {
                DGVUrunler.DataSource = mutfakIslem.mutfakIstenenUrunleriListele(urunAdi);

            }
            if (RBtnOda.Checked == true)
            {
                DGVUrunler.DataSource = odaIslem.odaIstenenUrunleriListele(urunAdi);
            }
        }

        private void BtnCikis13_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            DGVUrunler.RowHeadersVisible = false;
        }
    }
}
