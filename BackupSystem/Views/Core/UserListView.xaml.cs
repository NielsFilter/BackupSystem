using BackupSystem.ApplicationLogic.ViewModels.Core;
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

namespace BackupSystem.UI.Wpf.Views.Core
{
    /// <summary>
    /// Interaction logic for UserListView.xaml
    /// </summary>
    public partial class UserListView : UserControl
    {
        #region VM

        private UserListViewModel ViewModel
        {
            get
            {
                if (this.DataContext == null || !(this.DataContext is UserListViewModel))
                {
                    return null;
                }
                return (UserListViewModel)this.DataContext;
            }
        }

        #endregion

        #region Load

        public UserListView()
        {
            InitializeComponent();
        }

        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            this.ViewModel.OnLoad();
        }

        #endregion

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.ViewModel.OnRefresh();
        }

        private void List_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.ViewModel.GoDetail();
        }
    }
}
