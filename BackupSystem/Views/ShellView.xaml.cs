using BackupSystem.ApplicationLogic.ViewModels;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BackupSystem.UI.Wpf.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : MetroWindow
    {
        private ShellViewModel ViewModel
        {
            get
            {
                if (this.DataContext == null)
                {
                    return null;
                }
                return this.DataContext as ShellViewModel;
            }
        }

        public ShellView()
        {
            InitializeComponent();
            WpfContext.Current.MainContent = this.contentMain;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.ViewModel.OnLoad();
        }

        #region Menu 

        private void ShowMenu_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.ShowMenu();
        }

        private void GoToActivation_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.GoLicenseActivate();
        }

        #endregion
    }
}
