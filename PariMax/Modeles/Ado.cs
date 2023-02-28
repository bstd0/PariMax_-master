using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Modeles
{
    class Ado
    {
        public static SqlConnection database;
        public static void OuvrirConnexion()
        {
            database = new SqlConnection(@" Data Source = 172.20.7.54; Initial Catalog = bd_pari_max; User ID = user_pari_max;database=bd_pari_max;password=pwd_pari_max");
            database.Open();
        }

        public static void FermerConnexion()
        {
            database.Close();
        }
    }
}
