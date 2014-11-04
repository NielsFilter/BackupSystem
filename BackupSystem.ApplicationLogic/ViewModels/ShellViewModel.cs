using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.ApplicationLogic.ViewModels.Core;
using BackupSystem.ApplicationLogic.ViewModels.Tools;
using BackupSystem.Common.Mvvm.Commands;
using BackupSystem.Common.Mvvm.ViewModels;

namespace BackupSystem.ApplicationLogic.ViewModels
{
    public class ShellViewModel : PageViewModel
    {
        #region Constructors

        public ShellViewModel()
            : base()
        {
            this.IsMenuVisible = true;
            this.IsLoading = false;
        }

        #endregion

        #region Properties

        private bool _isMenuVisible;
        public bool IsMenuVisible
        {
            get
            {
                return this._isMenuVisible;
            }
            set
            {
                if (value != this._isMenuVisible)
                {
                    this._isMenuVisible = value;
                    base.NotifyPropertyChanged("IsMenuVisible");
                }
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get
            {
                return this._isLoading;
            }
            set
            {
                if (value != this._isLoading)
                {
                    this._isLoading = value;
                    base.NotifyPropertyChanged("IsLoading");
                }
            }
        }

        #endregion

        #region Load & Refresh

        public override void OnLoad()
        {
            base.OnLoad();

            if (SessionContext.Current.LoggedInUser == null)
            {
                GoLogin();
            }
            else
            {
                GoHome();
            }
        }

        public override void OnRefresh()
        {
            base.OnRefresh();
        }

        #endregion

        #region Menu

        public void ShowMenu()
        {
            this.IsMenuVisible = true;
        }

        private void HideMenu()
        {
            this.IsMenuVisible = false;
        }

        #endregion

        #region Navigation

        public void GoLogin()
        {
            base.Navigate(new LoginViewModel());
        }

        public void GoHome()
        {
            base.Navigate(new HomeViewModel());
        }

        public void GoGenerateLicenseKey()
        {
            base.Navigate(new ActivationKeyGeneratorViewModel());
        }

        public void GoLicenseActivate()
        {
            base.Navigate(new UserActivationViewModel());
        }

        #endregion
    }
}

