using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BackupSystem.ApplicationLogic.ViewModels.Core
{
    public class LoginViewModel : PageViewModel
    {
        #region Constructors

        public LoginViewModel()
            : base()
        {
        }

        #endregion

        #region Properties

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
                    this.validate("Username");
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
                    this.validate("Password");
                    base.NotifyPropertyChanged("Password");
                }
            }
        }

        #endregion

        #region Page Validations

        private void validate(string propertyName)
        {
            base.ClearValidationErrors(propertyName);

            // Username
            if (propertyName == "Username" || propertyName == null)
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(this.Username))
                {
                    errors.Add("Username is required");
                }

                base.AddValidationError(propertyName, errors);
            }

            // Password
            if (propertyName == "Password" || propertyName == null)
            {
                List<string> errors = new List<string>();
                if (string.IsNullOrEmpty(this.Password))
                {
                    errors.Add("Password is required");
                }

                if (this.Password.Length < 6)
                {
                    errors.Add("Password must be greater than 6 characters");
                }

                base.AddValidationError(propertyName, errors);
            }
        }

        #endregion

        #region Login

        public void Login()
        {
            // Validate all fields
            validate(null);

            //base.ShowLoading(() =>
            //    {
            //        bool validLogin = false;
            //        using (BackupSystemEntities ctx = new BackupSystemEntities())
            //        {
            //            var user = ctx.Users.FirstOrDefault(u => u.Username == this.Username);
            //            if (user != null)
            //            {
            //                validLogin = user.ValidatePassword(this.Password);
            //                if (validLogin)
            //                {
            //                    SessionContext.Current.LoggedInUser = user;
            //                    base.ChangeViewModel(new BestFitCalculatorViewModel());
            //                    return;
            //                }
            //            }
            //        }

            //        this.DialogService.ShowMessageBox(this, "Invalid username or password", "Login failed", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            //    }, "Logging in...");
        }

        #endregion
    }
}
