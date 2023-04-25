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
        List<Pari> Liste = new List<Pari>();
        List<PariSpe> Liste_spec = new List<PariSpe>();
        public PagePari()
        {
            InitializeComponent();
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
                txtbox_ptposs.Text = Convert.ToString((DtG_Maths.SelectedItem as Pari).Point);
                
            }
            if (DtG_Maths.SelectedItem != null)
            {
                (DtG_Maths.SelectedItem as Pari).Libelle = tbx_NomEquipe.Text;
                (DtG_Maths.SelectedItem as Pari).DteFin = Convert.ToDateTime(Tbx_Date.Text);
                (DtG_Maths.SelectedItem as Pari).Point = Convert.ToInt32(txtbox_ptposs.Text);
                MessageBox.Show("Modifications apportée");

                DtG_Maths.Items.Refresh();
            }
        }

        private void Btn_Crea_Click(object sender, RoutedEventArgs e)
        {
            pari_classique.IsEnabled = false;
            Grid_Creation.Visibility = Visibility.Visible;
            Grid_Modif.Opacity = 0.5;
            Grid_Creation.IsEnabled = true;
        }

        private void btn_Cancelled_Click(object sender, RoutedEventArgs e)
        {
            Grid_Modif.IsEnabled = true;
            Grid_Creation.Visibility = Visibility.Hidden;
            Grid_Modif.Opacity = 1;

        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            DateTime t = Convert.ToDateTime(Tbx_DateC.Text);
            string equipe = tbx_Equipe1.Text;
            int b = Convert.ToInt32(txt_ptposs.Text);
            bool c = chk_elmine.IsEnabled;
            PariNor z = new PariNor(equipe, b, t ,"gagnant",c);
            Liste.Add(z);
            DtG_Maths.ItemsSource = Liste;
            DtG_Maths.Items.Refresh();

                
           // (DtG_Maths.SelectedItem as Pari).Libelle = equipe;
            //(DtG_Maths.SelectedItem as Pari).DteFin = date;
            DtG_Maths.Items.Refresh();
            Grid_Creation.Visibility = Visibility.Hidden;
            Grid_Creation.IsEnabled = false;
            Grid_Modif.Opacity = 100;
            DtG_Maths.IsEnabled = true;
            pari_classique.IsEnabled = true;
        }

        private void DtG_Maths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_Supp_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Êtes vous sûr ?", "Attention", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                DtG_Maths.Items.Refresh();
            }
        }

        private void btn_spec_Click(object sender, RoutedEventArgs e)
        {
            pari_classique.Visibility= Visibility.Hidden;
            pari_classique.IsEnabled = false;
            btn_class.Visibility = Visibility.Visible;
            btn_spec.Visibility = Visibility.Hidden;
            pari_speciaux.Visibility= Visibility.Visible;
            pari_speciaux.IsEnabled = true;
            DtG_SPECIAUX.Items.Refresh();


        }

        private void btn_class_Click(object sender, RoutedEventArgs e)
        {
            pari_classique.Visibility = Visibility.Visible;
            pari_classique.IsEnabled = true;
            btn_class.Visibility = Visibility.Hidden;
            btn_spec.Visibility = Visibility.Visible;
            pari_speciaux.Visibility = Visibility.Hidden;
            pari_speciaux.IsEnabled = false;DtG_Maths.Items.Refresh();
            DtG_Maths.Items.Refresh();

        }


    }
}
