using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Otel_Otomasyonu_Projesi
{
    public partial class FormHavaDurumu : Form
    {
        //Xml kullanarak meteoroloji genel müdürlüğünün sitesinde hava durumu bilgilerini çekip getirir.
        private string havaDurumuLink = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public FormHavaDurumu()
        {
            InitializeComponent();
        }

        private void FormHavaDurumu_Load(object sender, EventArgs e)
        {
            DGVHavaDurum.RowHeadersVisible = false;
            
            DGVHavaDurum.ColumnHeadersDefaultCellStyle.ForeColor = Color.Purple;
            XmlDocument document1 = new XmlDocument();
            document1.Load(havaDurumuLink);
            XmlElement root = document1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");//sehirler başlıklı kısımını seçer.
           
            foreach(XmlNode node in nodes)
            {
                string il = node["ili"].InnerText;//xml ile xml bağlantısındaki sehirler in ili durum, maksimum sıcaklık verilerini çeker.
                string durum = node["Durum"].InnerText;
                string maximumSicaklik = node["Mak"].InnerText;
                DataGridViewRow row = (DataGridViewRow)DGVHavaDurum.Rows[0].Clone();
                row.Cells[0].Value = il;//çektiği tüm verileri data grid view'e yazar.
                row.Cells[1].Value = durum;
                row.Cells[2].Value = maximumSicaklik;
                DGVHavaDurum.Rows.Add(row);


                
            }

        }

        private void DGVHavaDurum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow satir in DGVHavaDurum.Rows)
            {
                if (Convert.ToInt32(satir.Cells[2].Value)>=30)
                {
                    //sıcaklık durumuna göre data grid view'in satırını renklendirir. Sıcaklık değeri 30'dan büyük olan şehirleri kırmızı gösterir.
                    satir.DefaultCellStyle.BackColor = Color.Red;
                }
               
            }
        }

        private void BtnCikis21_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
