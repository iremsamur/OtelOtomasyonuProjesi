using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Otomasyonu_Projesi
{
    public partial class FormMusteriler : Form
    {
        //müşterilerle ilgili bilgi güncelleme-silme gibi değişikliklerin yapıldığı formdur.
       
        VeritabaniBaglanti baglan = new VeritabaniBaglanti();
        MusteriIslemleri islem = new MusteriIslemleri();
        

        public FormMusteriler()
        {
            InitializeComponent();
        }
        
        private void MusterileriGoster()
        {
            listView1.Items.Clear();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand musterileriGetir = new SqlCommand("SELECT * FROM Table_Musteriler", baglan.connect);
                SqlDataReader reader = musterileriGetir.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = reader["MusteriId"].ToString();
                    ekle.SubItems.Add(reader["MusteriAdi"].ToString());
                    ekle.SubItems.Add(reader["MusteriSoyadi"].ToString());
                    ekle.SubItems.Add(reader["MusteriCinsiyet"].ToString());
                    ekle.SubItems.Add(reader["MusteriTelefon"].ToString());
                    ekle.SubItems.Add(reader["MusteriAdres"].ToString());
                    ekle.SubItems.Add(reader["MusteriMail"].ToString());
                    ekle.SubItems.Add(reader["MusteriTc"].ToString());
                    ekle.SubItems.Add(reader["OdaNo"].ToString());
                    ekle.SubItems.Add(reader["Ucret"].ToString());
                    ekle.SubItems.Add(reader["GirisTarihi"].ToString());
                    ekle.SubItems.Add(reader["CikisTarihi"].ToString());
                    ekle.SubItems.Add(reader["MusteriOdaTuru"].ToString());
                    listView1.Items.Add(ekle);
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
        

        private void BtnMusteriGoster_Click(object sender, EventArgs e)
        {
            MusterileriGoster();
        }
        private int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtMusteriAdi2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtMusteriSoyadi2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CBCinsiyet2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskMusteriTel2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            RTBAdres2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtMusteriMail2.Text =listView1.SelectedItems[0].SubItems[6].Text;
            TxtMusteriTc2.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtOdaNo2.Text = listView1.SelectedItems[0].SubItems[8].Text;
            TxtUcret2.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpGirisTarih2.Text = listView1.SelectedItems[0].SubItems[10].Text;
            DtpCikisTarih2.Text = listView1.SelectedItems[0].SubItems[11].Text;
            
            TxtOdaTuru2.Text = listView1.SelectedItems[0].SubItems[12].Text;
        }

        private void BtnBilgiSil_Click(object sender, EventArgs e)
        {
            
            islem.MusteriSil(id,Convert.ToInt32(TxtOdaNo2.Text));
            MusterileriGoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtMusteriAdi2.Clear();
            TxtMusteriSoyadi2.Clear();
            CBCinsiyet2.Text = "";
            MskMusteriTel2.Clear();
            RTBAdres2.Clear();
            TxtMusteriMail2.Clear();
            TxtMusteriTc2.Clear();
            TxtOdaNo2.Clear();
            TxtUcret2.Clear();
            DtpGirisTarih2.Text = "";
            DtpCikisTarih2.Text = "";
            TxtOdaTuru2.Clear();


        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            DateTime GirisTarih = Convert.ToDateTime(DtpGirisTarih2.Value);
            DateTime CikisTarih = Convert.ToDateTime(DtpCikisTarih2.Value);
            TimeSpan sonuc = CikisTarih - GirisTarih;

            if(Convert.ToInt32(TxtOdaNo2.Text)>=101 && Convert.ToInt32(TxtOdaNo2.Text) <= 109)
            {
                //oda numarası 101-109 arasında olanların ücret tutarını bir günlük bir oda 500 TL olarak hesaplar.
                TxtUcret2.Text = (Convert.ToInt32(sonuc.TotalDays.ToString()) * 500).ToString();
            }
            else if(Convert.ToInt32(TxtOdaNo2.Text) >= 201 && Convert.ToInt32(TxtOdaNo2.Text) <= 209)
            {
                //oda numarası 201-209 arasında olanların ücret tutarını bir günlük bir oda 750 TL olarak hesaplar.
                TxtUcret2.Text = (Convert.ToInt32(sonuc.TotalDays.ToString()) * 750).ToString();
            }
            else
            {
                MessageBox.Show(TxtOdaNo2.Text + " numaralı bir oda bulunmamaktadır !!","Hata | Otel Otomasyonu"+MessageBoxButtons.OKCancel+MessageBoxIcon.Information);
            }
           
            

            islem.MusteriBilgiGuncelle(id, TxtMusteriAdi2.Text,TxtMusteriSoyadi2.Text,CBCinsiyet2.Text,MskMusteriTel2.Text,RTBAdres2.Text,TxtMusteriMail2.Text,TxtMusteriTc2.Text,Convert.ToInt32(TxtOdaNo2.Text),TxtUcret2.Text,GirisTarih,CikisTarih,TxtOdaTuru2.Text);
            MusterileriGoster();
        }
     

        private void BtnBilgiAra_Click(object sender, EventArgs e)
        {
            //Girilen müşteri isimine göre kayıtlı müşterilerde filtreleme işleminin yapılmasını sağlar.
            listView1.Items.Clear();
            if (baglan.connect.State == System.Data.ConnectionState.Open)
            {
                baglan.connect.Close();
            }
            try
            {
                baglan.connect.Open();
                SqlCommand musterileriAraGetir = new SqlCommand("SELECT * FROM Table_Musteriler WHERE MusteriAdi LIKE '%"+TBArama.Text+"%'", baglan.connect);
               
                SqlDataReader reader = musterileriAraGetir.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = reader["MusteriId"].ToString();
                    ekle.SubItems.Add(reader["MusteriAdi"].ToString());
                    ekle.SubItems.Add(reader["MusteriSoyadi"].ToString());
                    ekle.SubItems.Add(reader["MusteriCinsiyet"].ToString());
                    ekle.SubItems.Add(reader["MusteriTelefon"].ToString());
                    ekle.SubItems.Add(reader["MusteriAdres"].ToString());
                    ekle.SubItems.Add(reader["MusteriMail"].ToString());
                    ekle.SubItems.Add(reader["MusteriTc"].ToString());
                    ekle.SubItems.Add(reader["OdaNo"].ToString());
                    ekle.SubItems.Add(reader["Ucret"].ToString());
                    ekle.SubItems.Add(reader["GirisTarihi"].ToString());
                    ekle.SubItems.Add(reader["CikisTarihi"].ToString());
                    ekle.SubItems.Add(reader["MusteriOdaTuru"].ToString());
                    listView1.Items.Add(ekle);
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

        private void BtnCikis9_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();

        }
    }
}
