/*using System;
using PariMax.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Configuration;

namespace PariMax.Modeles
{
    internal class AdoUtilisateur : Ado
    {
        public static string GetCurrentDomainPath()
        {
            return "";
        }

        public static List<Utilisateur> AjoutUtilisateur()
        {
            //List<Promotion> promotions = AdoUtilisateur.AjoutUtilisateur();
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            Ado.OuvrirConnexion();
            SqlCommand command = new SqlCommand("SELECT * FROM utilisateurs");
            command.Connection = database;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["idpromotion"]);
                /*foreach (Promotion promotion in promotions)
                   
                Promotion p = PariMax.Vues.FenetrePrincipale.cl.Where(c => c.Id == id).First();
                Utilisateur user = new Utilisateur(Convert.ToString(reader["nom"]), Convert.ToString(reader["prenom"]), Convert.ToString(reader["pseudo"]), Convert.ToInt32(reader["isJoueur"]));
                if (reader["point"] != null || reader["point"] != DBNull.Value)
                {
                    user.Point = Convert.ToInt32(reader["points"]);
                }
                p.AjoutUtilisateur(user);
                utilisateurs.Add(user);
            }

            reader.Close();
            Ado.FermerConnexion();

            return utilisateurs;
        }

    }
}
*/