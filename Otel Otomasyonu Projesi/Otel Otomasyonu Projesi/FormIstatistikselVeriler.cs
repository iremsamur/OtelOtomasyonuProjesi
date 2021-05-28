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
    public partial class FormIstatistikselVeriler : Form
    {
        //Otel gelir-gider ve harcamalarıyla ilgili istatistiksel verilerin gösterildiği- grafiklerin gösterdiliği formdur.
        private double musteriKazancGelir = FormGelirGider.MusteriKazanc;
        private double faturaGider = FormGelirGider.FaturaToplam;
        private double personelMaasGider = FormGelirGider.PersonelMaas;
        private double urunGider = FormGelirGider.UrunToplam;
        private double gelir = FormGelirGider.MusteriKazanc;
        private double gider = FormGelirGider.FaturaToplam + FormGelirGider.UrunToplam + FormGelirGider.PersonelMaas;

      
        public FormIstatistikselVeriler()
        {
            InitializeComponent();
        }

        private void FormIstatistikselVeriler_Load(object sender, EventArgs e)
        {

            harcamalarPastaGrafikCiz();
            harcamalarKutuGrafikCiz();
            harcamalarCizgiGrafikCiz();
            gelirGiderPastaGrafikCiz();
            gelirGiderKutuGrafikCiz();
            gelirGiderCizgiGrafikCiz();
        

        


        }
        
        public void harcamalarCizgiGrafikCiz()
        {
            //Harcamalar için çizgi grafiğini düzenler.
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points.Add(musteriKazancGelir);
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points.Add(faturaGider);
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points.Add(personelMaasGider);
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points.Add(urunGider);
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points[0].AxisLabel = "Müşteri Kazanç";


            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points[1].AxisLabel = "Fatura Toplam ";
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points[2].AxisLabel = "Personel Maaşları";
            this.cizgiGrafikHarcamalar.Series["Harcamalar"].Points[3].AxisLabel = "Alınan Ürünler";
        }
        
        public void harcamalarPastaGrafikCiz()
        {
            //Harcamalar için pasta grafiğini düzenler.
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points.Add(musteriKazancGelir);
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points.Add(faturaGider);
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points.Add(personelMaasGider);
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points.Add(urunGider);

            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[0].Label = "Müşteri Kazanç";


            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[1].Label = "Fatura Toplam ";
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[2].Label = "Personel Maaşları";
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[3].Label = "Alınan Ürünler";

            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[0].Color = Color.Aqua;
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[1].Color = Color.Purple;
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[2].Color = Color.Pink;
            this.pastaHarcamalar.Series["pastaHarcamalar"].Points[3].Color = Color.Blue;
        }
        public void harcamalarKutuGrafikCiz()
        {
            //Harcamalar için kutu grafiğini düzenler.
            this.harcamalarKutu.Series["Harcamalar"].Points.Add(musteriKazancGelir);
            this.harcamalarKutu.Series["Harcamalar"].Points.Add(faturaGider);
            this.harcamalarKutu.Series["Harcamalar"].Points.Add(personelMaasGider);
            this.harcamalarKutu.Series["Harcamalar"].Points.Add(urunGider);
            this.harcamalarKutu.Series["Harcamalar"].Points[0].AxisLabel = "Müşteri Kazanç";


            this.harcamalarKutu.Series["Harcamalar"].Points[1].AxisLabel = "Fatura Toplam ";
            this.harcamalarKutu.Series["Harcamalar"].Points[2].AxisLabel = "Personel Maaşları";
            this.harcamalarKutu.Series["Harcamalar"].Points[3].AxisLabel = "Alınan Ürünler";
            this.harcamalarKutu.Series["Harcamalar"].Points[0].Color = Color.Green;
            this.harcamalarKutu.Series["Harcamalar"].Points[1].Color = Color.Purple;
            this.harcamalarKutu.Series["Harcamalar"].Points[2].Color = Color.Pink;
            this.harcamalarKutu.Series["Harcamalar"].Points[3].Color = Color.Yellow;

        }
        public void gelirGiderPastaGrafikCiz()
        {
            //gelir-gider için pasta grafiğini düzenler.
            this.pastaGelirGiderGrafik.Series["GelirGider"].Points.Add(gelir);
            this.pastaGelirGiderGrafik.Series["GelirGider"].Points.Add(gider);
         

            this.pastaGelirGiderGrafik.Series["GelirGider"].Points[0].Label = "Toplam Gelir";


            this.pastaGelirGiderGrafik.Series["GelirGider"].Points[1].Label = "Toplam Gider ";

            if (gelir > gider)
            {
                this.pastaGelirGiderGrafik.Series["GelirGider"].Points[0].Color = Color.Green;
                this.pastaHarcamalar.Series["GelirGider"].Points[1].Color = Color.Red;
            }
            else if (gelir < gider)
            {
                this.pastaGelirGiderGrafik.Series["GelirGider"].Points[0].Color = Color.Red;
                this.pastaGelirGiderGrafik.Series["GelirGider"].Points[1].Color = Color.Green;
            }
            else
            {

                this.pastaGelirGiderGrafik.Series["GelirGider"].Points[0].Color = Color.Blue;
                this.pastaGelirGiderGrafik.Series["GelirGider"].Points[1].Color = Color.Pink;
            }
          
           
        }
        
        public void gelirGiderKutuGrafikCiz()
        {
            //gelir-gider için kutu grafiğini düzenler.
            this.gelirGiderKutu.Series["GelirGider"].Points.Add(gelir);
            this.gelirGiderKutu.Series["GelirGider"].Points.Add(gider);
           
            this.gelirGiderKutu.Series["GelirGider"].Points[0].AxisLabel = "Otel Toplam Geliri";


            this.gelirGiderKutu.Series["GelirGider"].Points[1].AxisLabel = "Otel Toplam Gideri";

            if (gelir > gider)
            {
                this.gelirGiderKutu.Series["GelirGider"].Points[0].Color = Color.Green;
                this.gelirGiderKutu.Series["GelirGider"].Points[1].Color = Color.Red;
            }
            else if (gelir < gider)
            {
                this.gelirGiderKutu.Series["GelirGider"].Points[0].Color = Color.Red;
                this.gelirGiderKutu.Series["GelirGider"].Points[1].Color = Color.Green;
            }
            else
            {

                this.gelirGiderKutu.Series["GelirGider"].Points[0].Color = Color.Orange;
                this.gelirGiderKutu.Series["GelirGider"].Points[1].Color = Color.MediumPurple;
            }
            
  
        }
        public void gelirGiderCizgiGrafikCiz()
        {
            //Gelir-gider için çizgi grafiğini düzenler.
            this.gelirGiderCizgi.Series["GelirGider"].Points.Add(gelir);
            this.gelirGiderCizgi.Series["GelirGider"].Points.Add(gider);
         
            this.gelirGiderCizgi.Series["GelirGider"].Points[0].AxisLabel = "Otel Toplam Geliri";


            this.gelirGiderCizgi.Series["GelirGider"].Points[1].AxisLabel = "Otel Toplam Gideri ";
      
        }

        private void BtnCikis8_Click(object sender, EventArgs e)
        {
            FormGelirGider gelirGider = new FormGelirGider();
            gelirGider.Show();
            this.Hide();
        }
    }
}
