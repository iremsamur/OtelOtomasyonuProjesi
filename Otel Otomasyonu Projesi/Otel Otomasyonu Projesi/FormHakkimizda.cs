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
    public partial class FormHakkimizda : Form
    {
        //Otel hakkında temel bazı bilgilerin yer aldığı bir hakkımızda sayfasıdır.
        public FormHakkimizda()
        {
            InitializeComponent();
        }

        private void FormHakkimizda_Load(object sender, EventArgs e)
        {
            label3.Text = "Diamond Otel Antalya'da 1 Mayıs 2021 tarihinde kurulan 5 yıldızlı bir oteldir.";
            label5.Text = "Otelimiz verdiği hizmetleri 5 yıldızlı otel standartlarına uygun \nolarak vermektedir. \nOtelimiz 4 katlıdır. 1.katta tek kişilik 9 oda bulunurken" +
                " 2.katta 9 adet\n çift kişilik oda bulunmaktadır. \n 3.katta restoran bölümü , 4. katta spor salonu ve masaj salonu bulunmaktadır. ";
            label8.Text = "Bizim misyonumuz : \nHer bütçeye hitap edebilecek  ve müşterilerin kaldığı süre boyunca \nev rahatlığında hissetmelerini sağlayacak bir otel yaratmaktır.";
            label9.Text = "Bizim vizyonumuz : \n Otelimizi gelecekte daha zenginleştirmek ve müşterilerimizin \nkomforunu ve rahatlığını arttıracak kademeye getirmektir.";

        }

        private void BtnCikis20_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
