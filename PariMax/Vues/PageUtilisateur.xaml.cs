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
    /// Logique d'interaction pour PageUtilisateur.xaml
    /// </summary>
    public partial class PageUtilisateur : Page
    {
        List<Utilisateur> Liste = new List<Utilisateur>();
        public PageUtilisateur()
        {
            InitializeComponent();
            Utilisateur a = new Utilisateur("STD", true, "Santander", "Baptiste", true, 0);
            Utilisateur b = new Utilisateur("cest", true, "un", "test", true, 0);
            Liste.Add(a);
            Liste.Add(b);
            list.ItemsSource = Liste;
            list.Items.Refresh();
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Grid_Creation.IsEnabled = true;
            Grid_Creation.Visibility = Visibility.Visible;
            Grid_Basic.Opacity = 0.5;
            list.IsEnabled = false;
        }

        private void btn_Cancelled_Click(object sender, RoutedEventArgs e)
        {
            Grid_Creation.Visibility = Visibility.Hidden;
            Grid_Basic.Opacity = 1;
            list.IsEnabled = true;
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            string name = txtBox_FirstName.Text;
            string surname = txtBox_Lastname.Text;
            string username = txtBox_Username.Text;

            
            Random rnd = new Random();
            string password = Convert.ToString(rnd.Next(25345, 99860));
            
            list.Items.Refresh();
            Grid_Creation.Visibility = Visibility.Hidden;
            Grid_Creation.IsEnabled = false;
            Grid_Basic.Opacity = 1;
            list.IsEnabled = true;
        }

        private void True(object sender, RoutedEventArgs e)
        {

        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Êtes vous sûr ?", "Attention", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                list.Items.Refresh();
            }
        }

        private void btn_modif_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem == null)
            {
                MessageBox.Show("Aucune valeur Sélectionné");
            }
            else
            {
                Grid_Modif.IsEnabled = true;
                Grid_Modif.Visibility = Visibility.Visible;
                Grid_Basic.Opacity = 0.5;
                list.IsEnabled = false;
                txtBox_FirstNameModif.Text = Convert.ToString((list.SelectedItem as Utilisateur).Prenom);
                txtBox_LastnameModif.Text = Convert.ToString((list.SelectedItem as Utilisateur).Nom);
                txtBox_ModifUsername.Text = Convert.ToString((list.SelectedItem as Utilisateur).Pseudo);
                
            }
        }

        private void btn_CancelledModif_Click(object sender, RoutedEventArgs e)
        {
            Grid_Modif.Visibility = Visibility.Hidden;
            Grid_Modif.IsEnabled = false;
            Grid_Basic.Opacity = 1;
            list.IsEnabled = true;
        }

        private void btn_CreateModif_Click(object sender, RoutedEventArgs e)
        {
            string name = txtBox_FirstNameModif.Text;
            string surname = txtBox_LastnameModif.Text;
            string username = txtBox_ModifUsername.Text;
            
            
            (list.SelectedItem as Utilisateur).Prenom = name;
            (list.SelectedItem as Utilisateur).Nom = surname;
            (list.SelectedItem as Utilisateur).Pseudo = username;
            (list.SelectedItem as Utilisateur).IsJoueur = true;
            list.Items.Refresh();
            Grid_Modif.Visibility = Visibility.Hidden;
            Grid_Modif.IsEnabled = false;
            Grid_Basic.Opacity = 1;
            list.IsEnabled = true;
        }

        
    }
}
