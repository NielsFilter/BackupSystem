using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.DAL;
using BackupSystem.Domain;
using BackupSystem.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Core
{
    public class UserListViewModel : PageViewModel
    {
        private IUserService _userService;

        #region ctors

        public UserListViewModel(IParentViewModel parentVM)
            : base(parentVM)
        {
            this._userService = ServiceFactory.GetService<IUserService>();
        }

        #endregion

        #region Properties

        private ObservableCollection<User> _list;
        public ObservableCollection<User> List
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

        private User _selectedItem;
        public User SelectedItem
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
            this.OnLoad();
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
                    this.List = this._userService.GetUsers(this.SearchText);
                }, "Loading users...");
        }

        #endregion

        #region Navigate

        public void GoDetail()
        {
            if (this.SelectedItem != null)
            {
                base.Navigate(new UserDetailViewModel(this.ParentViewModel));
            }
        }

        #endregion
    }
}
