using BackupSystem.Common.Enums;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupSystem.ApplicationLogic
{
    public abstract class SessionContext : NotifyPropertyChangedBase
    {
        private const string CLIENT_CODE_VALUE = "ClientCode";
        private const string REGISTRY_PATH = "HKEY_LOCAL_MACHINE\\Software\\BackupSystem";

        #region Singleton Context Instance

        public SessionContext()
        {
            if (Current == null)
            {
                Current = this;
            }
        }

        public static SessionContext Current { get; protected set; } // Singleton context instance

        #endregion

        public virtual User LoggedInUser { get; set; }

        #region Navigate

        public virtual ViewModelBase MasterViewModel { get; set; }

        public abstract void Navigate(ViewModelBase viewModel);

        #endregion

        #region License and Activation

        public DateTime? LicenseExpiry { get; set; }

        public bool IsValidLicense
        {
            get
            {
                if (!this.LicenseExpiry.HasValue)
                {
                    return false;
                }

                return this.LicenseExpiry.Value >= DateTime.Today;
            }
        }

        private string _clientCode = null;
        public string ClientCode
        {
            get
            {
                if (String.IsNullOrEmpty(this._clientCode))
                {
                    var cc = Microsoft.Win32.Registry.GetValue(REGISTRY_PATH, CLIENT_CODE_VALUE, null);
                    if (cc != null)
                    {
                        var clientCode = cc.ToString();
                        if (!clientCode.StartsWith("CL"))
                        {
                            //TODO: Logging - Invalid client code.
                            this._clientCode = null;
                        }
                        this._clientCode = clientCode;
                    }
                }
                return this._clientCode;
            }
        }

        #endregion

        #region Dialogs, Messages...

        public abstract void ShowMessage(string message, string caption, UserMessageType messageType);

        #endregion
    }
}
