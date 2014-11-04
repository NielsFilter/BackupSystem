using BackupSystem.Common.Mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupSystem.ViewModel
{
    public class FtpConnectionDetailViewModel : ViewModelBase
    {
        private string _connectionName;
        public string ConnectionName
        {
            get
            {
                return this._connectionName;
            }
            set
            {
                if (value != this._connectionName)
                {
                    this._connectionName = value;
                    base.NotifyPropertyChanged("ConnectionName");
                }
            }
        }

        private string _url;
        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                if (value != this._url)
                {
                    this._url = value;
                    base.NotifyPropertyChanged("Url");
                }
            }
        }

        private string _username;
        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                if (value != this._username)
                {
                    this._username = value;
                    base.NotifyPropertyChanged("Username");
                }
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (value != this._password)
                {
                    this._password = value;
                    base.NotifyPropertyChanged("Password");
                }
            }
        }

        #region ctors

        public FtpConnectionDetailViewModel()
        {

        }

        #endregion

    }
}
