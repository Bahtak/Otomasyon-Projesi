using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace satışotomasyonu
{
    public static class GlobalClass
    {

        public static string mailadresi { get; set; }

        public static string Isim { get; set; }

        public static int siparişnumarası { get; set; }

        public static int kdvtoplami { get; set; }

        public static int kdvlitoplami { get; set; }

        public static int maliyet { get; set; }

        public static SqlConnection sqlConnection = new SqlConnection("Data Source=BAHTAK;Initial Catalog=satisotomaosyonu;Integrated Security=True");


    }
}
