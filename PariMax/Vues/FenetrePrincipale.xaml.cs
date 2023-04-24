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
        public FenetrePrincipale()
        {
            InitializeComponent();
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
