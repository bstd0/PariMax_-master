/*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PariMax.classes;
using Microsoft.Data.SqlClient;

namespace PariMax.Modeles
{
    internal class AdoPari: Ado
    {
        List<Bet> bets = new List<Bet>();
        Ado.open();
            SqlCommand command = new SqlCommand("SELECT * FROM paris");
        command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();

        reader.Close();
            Ado.close();

            return bets;
    }
}
*/