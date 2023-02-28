using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Classes
{
    public class PariSpe : Pari
    {
        private int id;
        private int penalite;
        private int ecart;

        public PariSpe(string libelle, int point, DateTime dteFin, string resultat, int penalite,int ecart) : base (libelle, point, dteFin, resultat)
        {
            Penalite = penalite;
            Ecart = ecart;
        }

        public int Id { get => id; set => id = value; }
        public int Penalite { get => penalite; set => penalite = value; }
        public int Ecart { get => ecart; set => ecart = value; }
    }
}
