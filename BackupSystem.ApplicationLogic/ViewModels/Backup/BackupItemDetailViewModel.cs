using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.DAL;
using BackupSystem.Domain;
using BackupSystem.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Backup
{
    public class BackupItemDetailViewModel : PageViewModel
    {
        private IBackupItemService _svcBackupItem;

        #region ctors

        public BackupItemDetailViewModel(IParentViewModel parentVM, BackupItem backupItem = null)
            : base(parentVM)
        {
            this._svcBackupItem = ServiceFactory.GetService<IBackupItemService>();

            this.IsAdd = (backupItem == null);

            if (!this.IsAdd)
            {
                this.SelectedBackupItem = backupItem;
            }
        }

        #endregion

        #region Properties

        private bool _isAdd;
        public bool IsAdd
        {
            get
            {
                return this._isAdd;
            }
            set
            {
                if (value != this._isAdd)
                {
                    this._isAdd = value;
                    base.NotifyPropertyChanged("IsAdd");
                }
            }
        }

        private BackupItem _selectedBackupItem;
        public BackupItem SelectedBackupItem
        {
            get
            {
                if (this._selectedBackupItem == null)
                {
                    this._selectedBackupItem = new BackupItem();
                }
                return this._selectedBackupItem;
            }
            set
            {
                if (value != this._selectedBackupItem)
                {
                    this._selectedBackupItem = value;
                    base.NotifyPropertyChanged("SelectedBackupItem");
                }
            }
        }

        #endregion

        #region Load / Refresh

        public override void OnLoad()
        {
            base.OnLoad();
        }

        public override void OnRefresh()
        {
            base.OnRefresh();
        }

        #endregion

        #region Save

        public void Save()
        {
            base.ShowLoading(() =>
            {
                if (this.SelectedBackupItem != null)
                {
                    try
                    {
                        this._svcBackupItem.Save(this.IsAdd, this.SelectedBackupItem);
                        //TODO: SHOW SAVE.
                    }
                    catch (Exception ex)
                    {
                        //base.ShowError("Save failed", ex.Message);
                        //TODO: SHOW ERROR.
                    }
                }
            }, "Saving user...");
        }

        private void validate()
        {

        }

        #endregion
    }
}
