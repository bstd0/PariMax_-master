using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Classes
{
    public class PariNor : Pari
    {
        private int id;
        private bool isEliminatoire;

        public PariNor(string libelle, int point, DateTime dteFin, string resultat, bool isEliminatoire) : base(libelle, point, dteFin, resultat)
        {
            IsEliminatoire = isEliminatoire;
        }

        public int Id { get => id; set => id = value; }
        public bool IsEliminatoire { get => isEliminatoire; set => isEliminatoire = value; }
    }
}
