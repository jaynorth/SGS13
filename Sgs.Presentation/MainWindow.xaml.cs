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
using Sgs.Presentation.View;
using Sgs.Presentation.ViewModel;

namespace Sgs.Presentation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // DataContext = new EtudiantListViewModel();
            LoadEtudiantsControls();

        }

        private EnseignantListViewModel _enseignantsVM;
        private EnseignantListViewModel EnseignantVM
        {
            get
            {
                if (_enseignantsVM == null) _enseignantsVM = new EnseignantListViewModel();
                return _enseignantsVM;
            }
        }



        private EtudiantListViewModel _etudiantsVM;

        private EtudiantListViewModel  EtudiantsVM
            {
                get
                {
                    if (_etudiantsVM == null )  _etudiantsVM = new EtudiantListViewModel();
                    return _etudiantsVM;
                }
            }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutView view = new AboutView();
            view.Owner = this;

            // Afiche une fenetre de dialigue modal
            view.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(this, "Voulez-vous quitter?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void LoadEtudiantsControls()
        {
              
        
            ListPnl.Content = new EtudiantListView();
            DetailPnl.Content = new EtudiantDetailView();
            DataContext = new EtudiantListViewModel();
            btn_Etudiant.IsEnabled = false;
            btn_Enseignant.IsEnabled = true;
        }
    
        private void btn_Etudiant_Click(object sender, RoutedEventArgs e)
        {
            ListPnl.Content = new EtudiantListView();
            DetailPnl.Content = new EtudiantDetailView();
            DataContext = new EtudiantListViewModel();
            btn_Etudiant.IsEnabled = false;
            btn_Enseignant.IsEnabled = true;
        }

        private void btn_Enseignant_Click(object sender, RoutedEventArgs e)
        {
            ListPnl.Content = new EnseignantListUserControl();
            DetailPnl.Content = new EnseignantDetailUserControl();
            DataContext = new EnseignantListViewModel();
            btn_Etudiant.IsEnabled = true;
            btn_Enseignant.IsEnabled = false;

        }

        //private void EtudiantListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    if ((sender == null) || !(sender is EtudiantListView))
        //        return;

        //    EtudiantDetail.DataContext = EtudiantsList.ListViewEtudiants.SelectedItem;
        //}
    }
}
