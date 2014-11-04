using BackupSystem.Common.Mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BackupSystem.ApplicationLogic.ViewModels.Base
{
    public class PageViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        #region Navigate

        public void Navigate(ViewModelBase viewModel)
        {
            this.Context.Navigate(viewModel);
        }

        #endregion

        #region Validation

        private readonly Dictionary<string, IEnumerable<string>> _validationErrors = new Dictionary<string, IEnumerable<string>>();
        public void AddValidationError(string propertyName, ICollection<string> errors, bool notifyErrorOccurred = true)
        {
            if (_validationErrors == null || string.IsNullOrEmpty(propertyName))
            {
                return;
            }

            if (this._validationErrors.ContainsKey(propertyName))
            {
                _validationErrors[propertyName] = _validationErrors[propertyName].Union(errors);
            }
            else
            {
                _validationErrors.Add(propertyName, errors);
            }

            if (notifyErrorOccurred)
            {
                this.NotifyErrorsChanged(propertyName);
            }
        }

        public void ClearValidationErrors(string propertyName = null)
        {
            if (propertyName == null)
            {
                _validationErrors.Clear();
            }
            else
            {
                _validationErrors.Remove(propertyName);
            }
        }

        private void NotifyErrorsChanged(string propertyName)
        {
            if (this.ErrorsChanged != null)
            {
                this.ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        #region INotifyDataErrorInfo Members

        public bool HasErrors
        {
            get { return this._validationErrors.Count > 0; }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || !this._validationErrors.ContainsKey(propertyName))
            {
                return null;
            }

            return this._validationErrors[propertyName];
        }

        #endregion

        #endregion

        #region Context

        public SessionContext Context
        {
            get { return SessionContext.Current; }
        }

        #endregion
    }
}
