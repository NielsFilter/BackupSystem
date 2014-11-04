using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BackupSystem.ViewModel
{
    public class FtpConnectionListViewModel : ViewModelBase
    {
        private ObservableCollection<FtpConnection> _ftpConnectionList;
        public ObservableCollection<FtpConnection> FtpConnectionList
        {
            get
            {
                return this._ftpConnectionList;
            }
            set
            {
                if (value != this._ftpConnectionList)
                {
                    this._ftpConnectionList = value;
                    base.NotifyPropertyChanged("FtpConnectionList");
                }
            }
        }
        #region ctors

        public FtpConnectionListViewModel()
        {
            this.load();
        }

        #endregion

        #region Commands

        private void load()
        {
            refreshList();
        }

        private void refreshList()
        {
            using (BackupSystem.DAL.BackupSystemEntities ctx = new BackupSystemEntities())
            {
                this.FtpConnectionList = ctx.FtpConnections.Local;
            }
        }

        #endregion

    }
}

