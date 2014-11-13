using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.DAL;
using BackupSystem.Domain;
using BackupSystem.Domain.IServices;
using BackupSystem.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Core
{
    public class UserDetailViewModel : PageViewModel
    {
        private IUserService _userService;

        #region ctors

        public UserDetailViewModel(IParentViewModel parentVM, User user = null)
            : base(parentVM)
        {
            this._userService = ServiceFactory.GetService<IUserService>();

            this.IsAdd = (user == null);

            if (this.IsAdd)
            {
                this.SelectedUser = new User();
            }
            else
            {
                this.SelectedUser = user;
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


        private User _selectedUser;
        public User SelectedUser
        {
            get
            {
                if (this._selectedUser == null)
                {
                    this._selectedUser = new User();
                }
                return this._selectedUser;
            }
            set
            {
                if (value != this._selectedUser)
                {
                    this._selectedUser = value;
                    base.NotifyPropertyChanged("SelectedUser");
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
                if (this.SelectedUser != null)
                {
                    try
                    {
                        _userService.Save(this.IsAdd, this.SelectedUser);
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
