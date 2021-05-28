using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Otomasyonu_Projesi
{
    public class VeritabaniBaglanti
    {
        //Veritabanı bağlantı adresinin tutulduğu classtır.
        //static string baglanti = "Data Source=LAPTOP-I167GD4G\\SQLEXPRESS;Initial Catalog=OtelOtomasyonuDatabase;Integrated Security=True;" + "MultipleActiveResultSets=True;";
        static string baglanti = "Data Source=.\\SQLEXPRESS;Initial Catalog=OtelOtomasyonuDatabase;Integrated Security=True;" + "MultipleActiveResultSets=True;";
        //Burada bilgisayarında tüm sqlexpress server bulunan kullanıcılarda çalışabilmesi için . kullanarak bağlantı adresini yazdım.
        //Burada MultipleActiveResultSets=True; kullanımı ile SqlDataReader kullanımını yapacağım zaman , veritabanından gelecek olan birden fazla yani
        //çoklu satırların okunmasını sağlar. Bunu kullanmazsam program veritabanından okuma işlemlerinde doğru çalışmıyordu.
        public SqlConnection connect = new SqlConnection(baglanti);




    }
}
