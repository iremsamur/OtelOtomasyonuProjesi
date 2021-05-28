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
    public partial class FormRadyoDinle : Form
    {
        public FormRadyoDinle()
        {
            InitializeComponent();
        }
        //MediaPlayer ile gönderilen url'nin açılmasını ,radyonun çalmasını sağlar.

        private void LinkLblRadyo1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerturk/abr/powerturk/128/playlist.m3u8";
        }

        private void LinkLblRadyo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.radyofenomen.com/fenomen/256/icecast.audio";
        }

        private void LinkLblRadyo3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtmemleketimfm.live.trt.com.tr/master.m3u8";
        }

        private void LinkLblRadyo4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtradyohaber.live.trt.com.tr/master.m3u8";
        }
        private void linkLblRadyo5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://ssldyg.radyotvonline.com/smil/smil:kralpop.smil/playlist.m3u8";
        }

        private void LinkLblRadyo6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://ssl4.radyotvonline.com/radyohome/trtturku.stream_aac/playlist.m3u8";
        }

        private void LinkLblRadyo7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.211.162.32:8000/";
        }

        private void BtnKapat2_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
