using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyonu_Projesi
{
    public class Admin:User
    {

       
        private string AKullaniciAdi;
        private string AParola;
        
        private string AGirisTarih;
        
    
        public Admin()
        {

        }

        
        public string AdminKullaniciAdi
        {
            get
            {
                return AKullaniciAdi;
            }
            set
            {
                AKullaniciAdi = value;
            }
        }
        public string AdminParola
        {
            get
            {
                return AParola;
            }
            set
            {
                AParola = value;
            }
        }
       
        public string AdminGirisTarih
        {
            get
            {
                return AGirisTarih;
            }
            set
            {
                AGirisTarih = value;
            }
        }
       
     
    }
}
