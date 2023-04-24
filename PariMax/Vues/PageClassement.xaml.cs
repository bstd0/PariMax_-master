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
        }

        private void DtGridCls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ScrllBarCls_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
