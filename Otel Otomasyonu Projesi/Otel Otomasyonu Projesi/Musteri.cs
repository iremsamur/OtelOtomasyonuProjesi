using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyonu_Projesi
{
    class Musteri : User
    {
        private string MCinsiyet;
        private string MAdres;
        private int MOdaNo;
        private string MUcret;
        private string MGirisTarihi;
        private string MCikisTarihi;
        private string MOdaTuru;

        //private string AGirisTarih;

        public Musteri()
        {
           
        }
        public Musteri(int id,string ad,string soyad,string cinsiyet,string telefon,string adres,string mail,string tc,string odaNo,string ucret,string girisTarih,string cikisTarih,string odaTur)
        {
           
        }
        public string MusteriCinsiyet
        {
            get
            {
                return MCinsiyet;
            }
            set
            {
                MCinsiyet = value;
            }
        }
        public string MusteriAdres
        {
            get
            {
                return MAdres;
            }
            set
            {
                MAdres = value;
            }
        }
        public int MusteriOdaNo
        {
            get
            {
                return MOdaNo;
            }
            set
            {
                MOdaNo = value;
            }
        }
        public string MusteriUcret
        {
            get
            {
                return MUcret;
            }
            set
            {
                MUcret = value;
            }
        }
        public string MusteriGirisTarihi
        {
            get
            {
                return MGirisTarihi;
            }
            set
            {
                MGirisTarihi = value;
            }
        }
        public string MusteriCikisTarihi
        {
            get
            {
                return MCikisTarihi;
            }
            set
            {
                MCikisTarihi = value;
            }
        }

        public string MusteriOdaTuru
        {
            get
            {
                return MOdaTuru;
            }
            set
            {
                MOdaTuru = value;
            }
        }

    }
}
