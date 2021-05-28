using System;
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
    public partial class FormMesajlar : Form
    {
        /*Bu form da ise müşterilerin otel ile ilgili mesajlarını yani beklentilerini, isteklerini ve şikayetlerini resepsiyonist'e ilettikleri ve resepsiyonistin bunları not aldığı bölümdür.
         */
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        Mesajlar mesaj = new Mesajlar();
        public FormMesajlar()
        {
            InitializeComponent();
        }
        private void MesajlariGoster()
        {
            listViewMesajlar.Items.Clear();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand mesajlariGetir = new SqlCommand("SELECT * FROM Table_MusteriMesajlari", baglan.connect);
                SqlDataReader reader = mesajlariGetir.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = reader["MesajId"].ToString();
                    ekle.SubItems.Add(reader["MusteriAdSoyad"].ToString());
                    ekle.SubItems.Add(reader["Mesaj"].ToString());
                   
                    listViewMesajlar.Items.Add(ekle);
                }


            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu !!" + hata.Message);
            }
            finally
            {
                baglan.connect.Close();
            }

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            mesaj.mesajEkle(TxtAdSoyad.Text, RTBMesaj.Text);
            MesajlariGoster();
        }

        private void FormMesajlar_Load(object sender, EventArgs e)
        {
            MesajlariGoster();
            
        }
        int id = 0;
        private void listViewMesajlar_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listViewMesajlar.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listViewMesajlar.SelectedItems[0].SubItems[1].Text;
            RTBMesaj.Text = listViewMesajlar.SelectedItems[0].SubItems[2].Text;
        }

        private void BtnMesajGuncelle_Click(object sender, EventArgs e)
        {
            mesaj.musteriMesajBilgiGuncelle(id, TxtAdSoyad.Text, RTBMesaj.Text);
            MesajlariGoster();
        }

        private void BtnMesajSil_Click(object sender, EventArgs e)
        {
            mesaj.mesajSil(id);
            MesajlariGoster();
        }

        private void BtnAlanTemizle3_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Clear();
            RTBMesaj.Clear();
        }

        private void BtnCikis5_Click(object sender, EventArgs e)
        {
            FormAnaSayfa ana = new FormAnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
