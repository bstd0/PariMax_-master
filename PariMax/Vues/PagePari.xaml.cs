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
    /// Logique d'interaction pour PagePari.xaml
    /// </summary>
    public partial class PagePari : Page
    {
        public PagePari()
        {
            InitializeComponent();
        }

        private void DtG_Maths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_Valider_Click(object sender, RoutedEventArgs e)
        {
            if (DtG_Maths.SelectedItem == null)
            {
                MessageBox.Show("Aucune valeur Sélectionné");
            }
            else
            {
                tbx_NomEquipe.Text = Convert.ToString((DtG_Maths.SelectedItem as Pari).Libelle);
                Tbx_Date.Text = Convert.ToString((DtG_Maths.SelectedItem as Pari).DteFin);
            }
        }

        private void Btn_Crea_Click(object sender, RoutedEventArgs e)
        {
            Grid_Modif.IsEnabled = false;
            Grid_Creation.Visibility = Visibility.Visible;
            Grid_Modif.Opacity = 0.5;
            Grid_Creation.IsEnabled = true;
        }

        private void btn_Cancelled_Click(object sender, RoutedEventArgs e)
        {
            Grid_Creation.Visibility = Visibility.Hidden;
            Grid_Creation.IsEnabled = false;
            Grid_Creation.Opacity = 1;
            Grid_Modif.IsEnabled = true;
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            string equipe = tbx_NomEquipe.Text;
            //DateTime date = Tbx_Date.;


            (DtG_Maths.SelectedItem as Pari).Libelle = equipe;
            //(DtG_Maths.SelectedItem as Pari).DteFin = date;
            DtG_Maths.Items.Refresh();
            Grid_Creation.Visibility = Visibility.Hidden;
            Grid_Creation.IsEnabled = false;
            Grid_Modif.Opacity = 1;
            DtG_Maths.IsEnabled = true;
        }
    }
}
