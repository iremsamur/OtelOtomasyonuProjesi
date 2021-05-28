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
    public partial class FormGazeteler : Form
    {
        public FormGazeteler()
        {
            InitializeComponent();
        }
        //web Browser kullanarak içine verilen bağlantı linkinden bulunan gazeteyi bu sayfaya getirmeyi sağlar.
        private void BtnHurriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void BtnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void BtnSozcu_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sozcu.com.tr/");
        }

        private void BtnHaberTurk_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
        }

        private void BtnSabah_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
        }

        private void BtnVatan_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.gazetevatan.com/");

        }

        private void BtnCumhuriyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cumhuriyet.com.tr/");
        }

        private void BtnAksam_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.aksam.com.tr/");
        }

        private void BtnOnedio_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com/");
        }

        private void BtnFotoMac_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fotomac.com.tr/");
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
