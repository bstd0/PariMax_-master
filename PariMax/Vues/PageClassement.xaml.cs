using PariMax.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PariMax.Vues
{
    /// <summary>
    /// Logique d'interaction pour PageClassement.xaml
    /// </summary>
    public partial class PageClassement : Page
    {
        List<Utilisateur> Liste = new List<Utilisateur>();
        public PageClassement()
        {
            InitializeComponent();
            Utilisateur a = new Utilisateur("STD", true, "Santander", "Baptiste", true, 10);
            Utilisateur b = new Utilisateur("holstry", true, "Da silva", "Enzo", true, 2);
            Utilisateur c = new Utilisateur("Raf1715", true, "Robahlinio", "Rafael", true, 3);
            Utilisateur d = new Utilisateur("cestbon", true, "OH", "La", true, 9);
            Utilisateur e = new Utilisateur("toto", true, "Manzi", "Theo", true, 20);
            Utilisateur f = new Utilisateur("dede", true, "Dela", "Greg", true, 56);
            Utilisateur g = new Utilisateur("allez", true, "Hono", "Kenzak", true, 12);
            Utilisateur h = new Utilisateur("legk", true, "Legrand", "Kevin", true, 5);
            Utilisateur i = new Utilisateur("hiv", true, "Desplanche", "Ivan", true, 7);
            Utilisateur j = new Utilisateur("chronicle", true, "Menbu", "Gerard", true, 10);
            Utilisateur k = new Utilisateur("cest", true, "un", "test", true, 6);
            Liste.Add(a);
            Liste.Add(b);
            Liste.Add(c);
            Liste.Add(d);
            Liste.Add(e);
            Liste.Add(f);
            Liste.Add(g);
            Liste.Add(h);
            Liste.Add(i);
            Liste.Add(j);
            Liste.Add(k);
            list.ItemsSource = Liste;
            list.Items.Refresh();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ScrllBarCls_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
