using BackupSystem.ApplicationLogic.ViewModels.Backup;
using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.ApplicationLogic.ViewModels.Core;
using BackupSystem.ApplicationLogic.ViewModels.Tools;
using BackupSystem.Common.Enums;
using BackupSystem.Common.Mvvm.Commands;
using BackupSystem.Common.Mvvm.ViewModels;

namespace BackupSystem.ApplicationLogic.ViewModels
{
    public class ShellViewModel : PageViewModel, IParentViewModel
    {
        #region Constructors

        public ShellViewModel()
            : this(null)
        {

        }

        public ShellViewModel(IParentViewModel parentVM)
            : base(parentVM)
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

        private string _loadingMessage;
        public string LoadingMessage
        {
            get
            {
                return this._loadingMessage;
            }
            set
            {
                if (value != this._loadingMessage)
                {
                    this._loadingMessage = value;
                    base.NotifyPropertyChanged("LoadingMessage");
                }
            }
        }

        private bool _isPanelMessageShow;
        public bool IsPanelMessageShow
        {
            get
            {
                return this._isPanelMessageShow;
            }
            set
            {
                if (value != this._isPanelMessageShow)
                {
                    this._isPanelMessageShow = value;
                    base.NotifyPropertyChanged("IsPanelMessageShow");
                }
            }
        }

        private string _panelMessageHeader;
        public string PanelMessageHeader
        {
            get
            {
                return this._panelMessageHeader;
            }
            set
            {
                if (value != this._panelMessageHeader)
                {
                    this._panelMessageHeader = value;
                    base.NotifyPropertyChanged("PanelMessageHeader");
                }
            }
        }

        private string _panelMessageDetails;
        public string PanelMessageDetails
        {
            get
            {
                return this._panelMessageDetails;
            }
            set
            {
                if (value != this._panelMessageDetails)
                {
                    this._panelMessageDetails = value;
                    base.NotifyPropertyChanged("PanelMessageDetails");
                }
            }
        }

        private UserMessageType _panelMessageType;
        public UserMessageType PanelMessageType
        {
            get
            {
                return this._panelMessageType;
            }
            set
            {
                if (value != this._panelMessageType)
                {
                    this._panelMessageType = value;
                    base.NotifyPropertyChanged("PanelMessageType");
                }
            }
        }

        #endregion

        #region Load & Refresh

        public override void OnLoad()
        {
            base.OnLoad();
            base.AppContext.MasterViewModel = this;

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
            base.Navigate(new LoginViewModel(this));
        }

        public void GoHome()
        {
            base.Navigate(new HomeViewModel(this));
        }

        public void GoGenerateLicenseKey()
        {
            base.Navigate(new ActivationKeyGeneratorViewModel(this));
        }

        public void GoLicenseActivate()
        {
            base.Navigate(new UserActivationViewModel(this));
        }

        public void GoCreateBackup()
        {
            base.Navigate(new CreateBackupViewModel(this));
        }

        public void GoBackupItemList()
        {
            base.Navigate(new BackupItemListViewModel(this));
        }

        #endregion

        #region Notifications / Messages

        public void ShowPanelMessage(UserMessageType msgType, string caption, string message)
        {
            this.IsPanelMessageShow = false;
            this.PanelMessageType = msgType;

            if (caption == null)
            {
                caption = NotificationAttribute.GetCaption(msgType);
            }

            if (message == null)
            {
                message = NotificationAttribute.GetMessage(msgType);
            }

            this.PanelMessageHeader = caption;
            this.PanelMessageDetails = message;
        }

        #endregion
    }
}

