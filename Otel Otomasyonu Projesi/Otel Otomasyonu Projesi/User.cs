using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyonu_Projesi
{
    public class User
    {

        private int Id;
        private string Adi;
        private string Soyadi;
        private string Tc;
        private string Mail;
        private string Tel;
        public User()
        {

        }
        public int KullaniciId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string KullaniciIsim
        {
            get
            {
                return Adi;
            }
            set
            {
                Adi = value;
            }
        }
        public string KullaniciSoyisim
        {
            get
            {
                return Soyadi;
            }
            set
            {
                Soyadi = value;
            }
        }
        public string KullaniciTc
        {
            get
            {
                return Tc;
            }
            set
            {
                Tc = value;
            }
        }
        public string KullaniciMail
        {
            get
            {
                return Mail;
            }
            set
            {
                Mail = value;
            }
        }

    }
}
