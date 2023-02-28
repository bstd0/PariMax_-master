using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Classes
{
    public class PariEff
    {
        private int id;
        private Utilisateur utilisateur;
        private Pari pari;
        private int valeur;

        public PariEff(Utilisateur utilisateur, Pari pari, int valeur)
        {
            Utilisateur = utilisateur;
            Pari = pari;
            Valeur = valeur;
        }

        public int Id { get => id; set => id = value; }
        public Utilisateur Utilisateur { get => utilisateur; set => utilisateur = value; }
        public Pari Pari { get => pari; set => pari = value; }
        public int Valeur { get => valeur; set => valeur = value; }
    }
}
