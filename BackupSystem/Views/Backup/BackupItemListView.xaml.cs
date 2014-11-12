using BackupSystem.ApplicationLogic.ViewModels.Backup;
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

namespace BackupSystem.UI.Wpf.Views.Backup
{
    /// <summary>
    /// Interaction logic for BackupItemDetailView.xaml
    /// </summary>
    public partial class BackupItemListView : UserControl
    {
        #region VM

        private BackupItemListViewModel ViewModel
        {
            get
            {
                if (this.DataContext == null || !(this.DataContext is BackupItemListViewModel))
                {
                    return null;
                }
                return (BackupItemListViewModel)this.DataContext;
            }
        }

        #endregion

        #region Load

        public BackupItemListView()
        {
            InitializeComponent();
        }

        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            this.ViewModel.Load();
        }

        #endregion

        #region CRUD

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.Delete();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.Edit();
        }

        private void List_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.ViewModel.Edit();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.Add();
        }

        #endregion

        #region List / Refresh

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.ViewModel.Refresh();
        }

        #endregion
    }
}
