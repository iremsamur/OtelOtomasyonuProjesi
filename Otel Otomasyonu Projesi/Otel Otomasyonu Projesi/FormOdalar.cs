using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Otel_Otomasyonu_Projesi
{
    public partial class FormOdalar : Form
    {
        Odalar oda = new Odalar();

        public FormOdalar()
        {
            InitializeComponent();
        }
        ArrayList odalar = new ArrayList();
        

        private void FormOdalar_Load(object sender, EventArgs e)
        {
           

            odalarinDurumunuGoster();
            
            
        }
        //Odaların durumunu gösterir. 
        /*Dolu olan odaları kırmızı göstererek odanın üzerine kayıtlı olduğu kişinin isim-soyisim bilgilerini gösterir. Boş olan odaları ise yeşil renk ile göstererek, BOŞ yazısını gösterir.*/
        void odalarinDurumunuGoster()
        {
            oda101.Text = "Oda 105" + "\n" + "BOŞ";
            oda102.Text = "Oda 105" + "\n" + "BOŞ";
            oda103.Text = "Oda 105" + "\n" + "BOŞ";
            oda104.Text = "Oda 105" + "\n" + "BOŞ";
            oda105.Text = "Oda 105" + "\n" + "BOŞ";
            oda106.Text = "Oda 105" + "\n" + "BOŞ";
            oda107.Text = "Oda 105" + "\n" + "BOŞ";
            oda108.Text = "Oda 105" + "\n" + "BOŞ";
            oda109.Text = "Oda 105" + "\n" + "BOŞ";
            oda201.Text = "Oda 105" + "\n" + "BOŞ";
            oda202.Text = "Oda 105" + "\n" + "BOŞ";
            oda203.Text = "Oda 105" + "\n" + "BOŞ";
            oda204.Text = "Oda 105" + "\n" + "BOŞ";
            oda205.Text = "Oda 105" + "\n" + "BOŞ";
            oda206.Text = "Oda 105" + "\n" + "BOŞ";
            oda207.Text = "Oda 105" + "\n" + "BOŞ";
            oda208.Text = "Oda 105" + "\n" + "BOŞ";
            oda209.Text = "Oda 105" + "\n" + "BOŞ";
            List<string> liste = new List<string>();
            List<string> liste2 = new List<string>();
            string gecici = "";
            liste2 = oda.odadurumGetir();
            for (int i = 0; i < liste2.Count; i++)
            {
                if (Convert.ToInt32(liste2[i]) == 101)
                {
                   
                    oda101.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(101, "Dolu");
                    
                    for(int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    
                    oda101.Text = "Oda 101" + "\n" + gecici;
                    oda101.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 102)
                {
                    oda102.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(102, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda102.Text = "Oda 102" + "\n" + gecici;
                    oda102.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 103)
                {
                    oda103.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(103, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda103.Text = "Oda 103" + "\n" + gecici;
                    oda103.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 104)
                {
                  
                    oda104.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(104, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda104.Text = "Oda 104" + "\n" + gecici;
                    oda104.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 105)
                {
                    
                    oda105.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(105, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda105.Text = "Oda 105" + "\n" + gecici;
                    oda105.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 106)
                {
                    oda106.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(106, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda106.Text = "Oda 106" + "\n" + gecici;
                    oda106.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 107)
                {
                    oda107.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(107, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda107.Text = "Oda 107" + "\n" + gecici;
                    oda107.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 108)
                {
                    oda108.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(108, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda108.Text = "Oda 108" + "\n" + gecici;
                    oda108.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 109)
                {
                    oda109.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(109, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda109.Text = "Oda 109" + "\n" + gecici;
                    oda109.Enabled = false;
                }

                if (Convert.ToInt32(liste2[i]) == 201)
                {
                    oda201.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(201, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda201.Text = "Oda 201" + "\n" + gecici;
                    oda201.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 202)
                {
                    oda202.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(202, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda202.Text = "Oda 202" + "\n" + gecici;
                    oda203.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 203)
                {
                    oda203.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(203, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda203.Text = "Oda 203" + "\n" + gecici;
                    oda203.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 204)
                {
                    oda204.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(204, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda204.Text = "Oda 204" + "\n" + gecici;
                    oda204.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 205)
                {
                    oda205.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(205, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda205.Text = "Oda 205" + "\n" + gecici;
                    oda205.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 206)
                {
                    oda206.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(206, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda206.Text = "Oda 206" + "\n" + gecici;
                    oda206.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 207)
                {
                    oda207.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(207, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda207.Text = "Oda 207" + "\n" +gecici;
                    oda207.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 208)
                {
                    oda208.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(208, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda208.Text = "Oda 208" + "\n" + gecici;
                    oda208.Enabled = false;
                }
                if (Convert.ToInt32(liste2[i]) == 209)
                {
                   
                    oda209.BackColor = Color.Red;
                    liste = oda.odaBilgileriGetir(209, "Dolu");
                    for (int j = 0; j < liste.Count; j++)
                    {
                        gecici = liste[j].ToString();
                    }
                    oda209.Text = "Oda 209" + "\n" + gecici;
                    oda209.Enabled = false;
                }

            }

        }

        private void BtnCikis10_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
    }

