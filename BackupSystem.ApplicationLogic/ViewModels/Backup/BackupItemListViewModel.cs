using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.Common.Enums;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.DAL;
using BackupSystem.Domain;
using BackupSystem.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Backup
{
    public class BackupItemListViewModel : PageViewModel
    {
        private IBackupItemService _svcBackupItem;

        #region ctors

        public BackupItemListViewModel(IParentViewModel parentVM)
            : base(parentVM)
        {
            this.IsGridLoading = false;
            this._svcBackupItem = ServiceFactory.GetService<IBackupItemService>();
        }

        #endregion

        #region Properties

        private ObservableCollection<BackupItem> _list;
        public ObservableCollection<BackupItem> List
        {
            get
            {
                return this._list;
            }
            set
            {
                if (value != this._list)
                {
                    this._list = value;
                    base.NotifyPropertyChanged("List");
                    base.NotifyPropertyChanged("ListPaged"); // Notifies that the Paged collection has changed
                }
            }
        }

        public System.ComponentModel.ICollectionView ListPaged
        {
            get { return System.Windows.Data.CollectionViewSource.GetDefaultView(this.List); }
        }

        private BackupItem _selectedItem;
        public BackupItem SelectedItem
        {
            get
            {
                return this._selectedItem;
            }
            set
            {
                if (value != this._selectedItem)
                {
                    this._selectedItem = value;
                    base.NotifyPropertyChanged("SelectedItem");
                }
            }
        }

        private bool _isGridLoading;
        public bool IsGridLoading
        {
            get
            {
                return this._isGridLoading;
            }
            set
            {
                if (value != this._isGridLoading)
                {
                    this._isGridLoading = value;
                    base.NotifyPropertyChanged("IsGridLoading");
                }
            }
        }

        #endregion

        #region Load / Refresh

        public override void OnLoad()
        {
            base.OnLoad();
            this.loadList();
        }

        public override void OnRefresh()
        {
            base.OnRefresh();
            this.loadList();
        }

        private void loadList()
        {
            base.ShowLoading(setGridLoading, () =>
            {
                this.List = this._svcBackupItem.GetBackupItems(base.Pager.SearchText);
            });
        }

        private void setGridLoading(bool isGridLoading)
        {
            this.IsGridLoading = isGridLoading;
        }

        #endregion

        #region CRUD

        public void Delete()
        {
            base.ShowLoading(() =>
            {
                try
                {
                    this._svcBackupItem.Delete(this.SelectedItem);
                }
                catch (Exception ex)
                {
                    //TODO: SHOW FAILED
                    base.ParentViewModel.ShowPanelMessage(UserMessageType.ERROR, "Failed to delete backup item.", "");
                }
            }, "Deleting backup item...");
        }

        public void Edit()
        {
            base.Navigate(new BackupItemDetailViewModel(this.ParentViewModel, this.SelectedItem));
        }

        public void Add()
        {
            base.Navigate(new BackupItemDetailViewModel(this.ParentViewModel));
        }

        #endregion
    }
}
