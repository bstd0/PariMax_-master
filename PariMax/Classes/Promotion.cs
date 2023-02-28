using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Classes
{
    public class Promotion
    {
        private int id;
        private string libelle;
        private int code;

        public Promotion(string libelle, int code)
        {
            this.libelle = libelle;
            this.code = code;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Code { get => code; set => code = value; }
    }
}
