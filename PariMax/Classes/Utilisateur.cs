﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariMax.Classes
{
    public class Utilisateur
    {
        private int id;
        private string pseudo;
        private bool mdp;
        private string nom;
        private string prenom;
        private bool isJoueur;
        private int point;
        private Promotion promotion;

        public Utilisateur(string pseudo, bool mdp, string nom, string prenom, bool isJoueur, int point)
        {
            Pseudo = pseudo;
            Mdp = mdp;
            Nom = nom;
            Prenom = prenom;
            IsJoueur = isJoueur;
            Point = point;
        }

        public int Id { get => id; set => id = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public bool Mdp { get => mdp; set => mdp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public bool IsJoueur { get => isJoueur; set => isJoueur = value; }
        public int Point { get => point; set => point = value; }
        public Promotion Promotion { get => promotion; set => promotion = value; }
    }
}
