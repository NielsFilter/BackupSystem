using BackupSystem.ApplicationLogic;
using BackupSystem.ApplicationLogic.ViewModels;
using BackupSystem.ApplicationLogic.ViewModels.Backup;
using BackupSystem.ApplicationLogic.ViewModels.Core;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.UI.Wpf.Core;
using BackupSystem.UI.Wpf.Views.Backup;
using BackupSystem.UI.Wpf.Views.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace BackupSystem.UI.Wpf
{
    public class WpfContext : SessionContext
    {
        #region Singleton

        public static new WpfContext Current
        {
            get
            {
                if (SessionContext.Current == null)
                {
                    SessionContext.Current = new WpfContext();
                }
                return SessionContext.Current as WpfContext;
            }
        }

        #endregion

        private Dictionary<Type, Type> _pageLookup;
        internal Dictionary<Type, Type> PageLookup
        {
            get
            {
                if (this._pageLookup == null)
                {
                    this._pageLookup = new Dictionary<Type, Type>();

                    // Core
                    this._pageLookup.Add(typeof(HomeViewModel), typeof(HomeView));
                    this._pageLookup.Add(typeof(LoginViewModel), typeof(LoginView));
                    this._pageLookup.Add(typeof(UserActivationViewModel), typeof(UserActivation));
                    this._pageLookup.Add(typeof(UserListViewModel), typeof(UserListView));
                    this._pageLookup.Add(typeof(UserDetailViewModel), typeof(UserDetailView));

                    // Backup
                    this._pageLookup.Add(typeof(CreateBackupViewModel), typeof(CreateBackupView));
                    this._pageLookup.Add(typeof(BackupItemListViewModel), typeof(BackupItemListView));
                    this._pageLookup.Add(typeof(BackupItemDetailViewModel), typeof(BackupItemDetailView));
                }
                return this._pageLookup;
            }
        }

        #region Navigate

        internal ContentControl MainContent { get; set; }

        public override void Navigate(ViewModelBase viewModel)
        {
            if (this.MainContent != null)
            {
                Type pageType = this.PageLookup.FirstOrDefault(x => x.Key == viewModel.GetType()).Value;
                if (pageType == null)
                {
                    throw new NotImplementedException(String.Format("The ViewModel '{0}' has no corresponding view. You need hook it up to a view in '{1}'", viewModel.GetType().Name, this.GetType().Name));
                }

                FrameworkElement pg = Activator.CreateInstance(pageType) as FrameworkElement;
                if (pg != null)
                {
                    this.MainContent.Content = pg;
                    pg.DataContext = viewModel;
                }
            }
        }

        #endregion

        #region Dialogs, Messages...

        public override void ShowMessage(string message, string caption, Common.Enums.UserMessageType messageType)
        {
            // TODO: Customize this.
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #endregion
    }
}
