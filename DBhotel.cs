using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Renita_Perhotelan_XIIRPLB
{
    class DBhotel
    {
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username = 'root'; password = ''; database = 'hotel'");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string apakuerinya)
        {
            Console.WriteLine(apakuerinya);
            ds.Tables.Clear();
            perintah = new MySqlCommand(apakuerinya, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
         
    }

}
