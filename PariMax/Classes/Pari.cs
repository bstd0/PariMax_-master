using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Classes
{
    public class Pari
    {
        private int id;
        private string libelle;
        private int point;
        private DateTime dteFin;
        private string resultat;

        public Pari(string libelle, int point, DateTime dteFin, string resultat)
        {
            Libelle = libelle;
            Point = point;
            DteFin = dteFin;
            Resultat = resultat;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Point { get => point; set => point = value; }
        public DateTime DteFin { get => dteFin; set => dteFin = value; }
        public string Resultat { get => resultat; set => resultat = value; }

    }
}
