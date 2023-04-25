/*
using PariMax.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Modeles
{
    internal class AdoUser:Ado
    {
        public static string GetCurrentDomainPath()
        {
            return "";
        }

        public static List<Utilisateur> GetAll()
        {
            List<Utilisateur> classrooms = AdoUser.GetAll();
            List<Utilisateur> users = new List<Utilisateur>();
            Ado.open();
            SqlCommand command = new SqlCommand("SELECT * FROM users");
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["idpromotion"]);
                /*foreach (Classroom classroom in classrooms)
                {
                    if (classroom.Id==id)
                    {
                        User user = new User(Convert.ToString(reader["name"]), Convert.ToString(reader["lastname"]), Convert.ToString(reader["username"]), Convert.ToString(reader["email"]), Convert.ToInt32(reader["isplayer"]));
                        classroom.AddUser(user);
                        users.Add(user);
                    }
                }
                Promotion p = PariMax.MainWindow.cl.Where(c => c.Id == id).First();
                Utilisateur user = new Utilisateur(Convert.ToString(reader["name"]), Convert.ToString(reader["lastname"]), Convert.ToString(reader["username"]), Convert.ToString(reader["email"]), Convert.ToInt32(reader["isplayer"]));
                if (reader["points"] != null || reader["points"] != DBNull.Value)
                {
                    user.Points = Convert.ToInt32(reader["points"]);
                }
                p.AdoUser(user);
                users.Add(user);
            }

            reader.Close();
            Ado.close();

            return users;
        }

    }
}
*/