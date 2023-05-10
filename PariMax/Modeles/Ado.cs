using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Modeles
{
    public class Ado
    {
        public static SqlConnection database;
        public static void OuvrirConnexion()
        {
            database = new SqlConnection(@" Data Source = 172.20.7.41; Initial Catalog = bd_pari_max; User ID = user_pari_max; database=bd_pari_max; password=slampwd1!");
            database.Open();
        }

        public static void FermerConnexion()
        {
            database.Close();
        }

        public static void insert()
        {
            OuvrirConnexion();

            SqlCommand cmd = new SqlCommand("INSERT INTO TableName (FirstColumn) VALUES (@1)");
            cmd.Connection = database;
            cmd.Parameters.Add(new SqlParameter("1", 10));
            cmd.ExecuteNonQuery();

            FermerConnexion();
        }
    }
}
