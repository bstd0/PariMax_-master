/*using PariMax.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows;

namespace PariMax.Modeles
{
    public class AdoPromotion : Ado
    {
        public static string GetCurrentDomainPath()
        {
            try

            {
                DirectoryEntry Ldap = new DirectoryEntry("LDAP://SISRbest.local", "SLAM", "chefadmin321%");
                return "LDAP://SISRbest.local" + Ldap.Properties["defaultNamingContext"][0].ToString();

            }
            catch (Exception Ex)

            {

                Console.WriteLine(Ex.Message);
                return "en cours de réalisation ";

            }

        }

        public static List<Promotion> GetAll()
        {
            List<Promotion> promotions = new List<Promotion>();
            Ado.OuvrirConnexion();
            SqlCommand command = new SqlCommand("SELECT * FROM promotions");
            command.Connection = ;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                promotions.Add(new Promotion(Convert.ToInt32(reader["id"]), Convert.ToString(reader["name"])));
            }

            reader.Close();
            Ado.FermerConnexion();

            return promotions;
        }
        public static void AddPromotion(Promotion promotion)
        {
            FenetrePrincipal.cl.Add(promotion);
        }
    }
}
*/