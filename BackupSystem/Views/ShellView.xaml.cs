using BackupSystem.ApplicationLogic.ViewModels;
using BackupSystem.Styles.Wpf.Controls;
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
using BackupSystem.Common.Utils;

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
                if (this.DataContext == null || !(this.DataContext is ShellViewModel))
                {
                    return null;
                }
                return (ShellViewModel)this.DataContext;
            }
        }

        public ShellView()
        {
            InitializeComponent();
            WpfContext.Current.MainContent = this.contentMain;

            var themes = new[] { "BaseLight", "BaseDark" };
            var accents = new[] {
                                    "Red", "Green", "Blue", "Purple", "Orange", "Lime", "Emerald", "Teal", "Cyan", "Cobalt",
                                    "Indigo", "Violet", "Pink", "Magenta", "Crimson", "Amber", "Yellow", "Brown", "Olive", "Steel", "Mauve", "Taupe", "Sienna"
                               };

            var randomTheme = themes[new Random().Next(0, themes.Count() - 1)];
            var randomAccent = accents[new Random().Next(0, accents.Count() - 1)];

            var theme = BackupSystem.Styles.Wpf.ThemeManager.GetAppTheme(randomTheme);
            var accent = BackupSystem.Styles.Wpf.ThemeManager.GetAccent(randomAccent);

            BackupSystem.Styles.Wpf.ThemeManager.ChangeAppStyle(Application.Current, accent, theme);
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

        #endregion

        #region Navigation

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.GoHome();
        }

        private void GoToActivation_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.GoLicenseActivate();
        }

        private void CreateBackup_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.GoCreateBackup();
        }

        private void BackupItems_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.GoBackupItemList();
        }

        #endregion
    }
}
