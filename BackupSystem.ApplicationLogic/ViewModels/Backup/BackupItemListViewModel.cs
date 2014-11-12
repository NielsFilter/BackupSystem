using BackupSystem.ApplicationLogic.ViewModels.Base;
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

        public BackupItemListViewModel()
            : base()
        {
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

        private string _searchText;
        public string SearchText
        {
            get
            {
                return this._searchText;
            }
            set
            {
                if (value != this._searchText)
                {
                    this._searchText = value;
                    base.NotifyPropertyChanged("SearchText");
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
            base.ShowLoading(() =>
            {
                this.List = this._svcBackupItem.GetBackupItems(this.SearchText);
            }, "Loading users...");
        }

        #endregion

        #region CRUD

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
