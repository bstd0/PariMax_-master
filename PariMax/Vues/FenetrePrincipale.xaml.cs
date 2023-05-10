using PariMax.Classes;
using PariMax.Modeles;
using PariMax.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PariMax.Vues
{
    /// <summary>
    /// Logique d'interaction pour FenetrePrincipale.xaml
    /// </summary>
    public partial class FenetrePrincipale
    {

        //LA FONCTION SAVE SE TROUVE DANS APP.xaml.cs

        public static List<Promotion> cl = new List<Promotion>();
        public static List<Utilisateur> us = new List<Utilisateur>();

        public FenetrePrincipale()
        {
            InitializeComponent();
            //cl = AdoPromotion.GetAll();
            us = AdoUtilisateur.AjoutUtilisateur();

            //CALCUL des points des classes
            /*foreach (Promotion c in FenetrePrincipale.cl)
            {
                foreach (Utilisateur u in c.Utilisateurs)
                {
                    c. = c. + u.;
                }
            }*/
        }

        private void BtnCls_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PageClassement();
        }

        private void BtnUti_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PageUtilisateur();
        }

        private void BtnPari_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new PagePari();
        }
    }
}
