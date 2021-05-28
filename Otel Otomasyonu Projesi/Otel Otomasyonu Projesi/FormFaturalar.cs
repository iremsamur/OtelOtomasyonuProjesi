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
    public partial class FormFaturalar : Form
    {
        //Otelin elektrik,su gibi faturalarıyla ilgili işlemlerin gerçekleştirildiği class olur.
        FaturaIslemleri islem = new FaturaIslemleri();
        private string faturaid;
        public string faturaId
        {
            get
            {
                return faturaid;
            }
            set
            {
                faturaid = value;
            }
        }
        public FormFaturalar()
        {
            InitializeComponent();
        }

        private void BtnFaturaEkle_Click(object sender, EventArgs e)
        {
            DateTime faturaOdemeTarih = Convert.ToDateTime(DTPFaturaTarih.Value);
            islem.faturaEkle(TxtFaturaAdi.Text, TxtFaturaTutar.Text, faturaOdemeTarih);
            DGVFaturalar.DataSource = islem.faturalariListele();
        }

        private void BtnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            //data grid view tablosu üzerinden tıklanan faturanın id değerini alarak , id'ye göre bilgi güncelleme işlemini gerçekleştirir.
            int id = Convert.ToInt32(faturaId);
            DateTime faturaOdemeTarih = Convert.ToDateTime(DTPFaturaTarih.Value);
            islem.faturaBilgiGuncelle(id, TxtFaturaAdi.Text, TxtFaturaTutar.Text, faturaOdemeTarih);
            DGVFaturalar.DataSource = islem.faturalariListele();
        }

        private void DGVFaturalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid view üzerinde tıklanan satırın her bir hücresinde bulunan değerleri alıp, sayfadaki text boxlara yazmayı sağlar.
            faturaId = DGVFaturalar.CurrentRow.Cells[0].Value.ToString();//0.indiste bulunan id 'yi alır.

            TxtFaturaAdi.Text = DGVFaturalar.CurrentRow.Cells[1].Value.ToString();//1.indiste bulunan fatura adını alır.

            TxtFaturaTutar.Text = DGVFaturalar.CurrentRow.Cells[2].Value.ToString();
            DTPFaturaTarih.Value = Convert.ToDateTime(DGVFaturalar.CurrentRow.Cells[3].Value.ToString());
        }

        private void FormFaturalar_Load(object sender, EventArgs e)
        {
            DGVFaturalar.DataSource = islem.faturalariListele();
            DGVFaturalar.RowHeadersVisible = false;
        }

        private void BtnFaturaSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(faturaId);
            islem.faturaBilgiSil(id);
            DGVFaturalar.DataSource = islem.faturalariListele();
        }

        private void BtnFaturaGoster_Click(object sender, EventArgs e)
        {
            DGVFaturalar.DataSource = islem.faturalariListele();
        }

        private void BtnAlanlariTemizle2_Click(object sender, EventArgs e)
        {
            TxtFaturaAdi.Clear();
            TxtFaturaTutar.Clear();
            DTPFaturaTarih.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void BtnCikis6_Click(object sender, EventArgs e)
        {
            FormGelirGider gelirGider = new FormGelirGider();
            gelirGider.Show();
            this.Hide();
        }
    }
}
