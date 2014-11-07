using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.Common.Paging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BackupSystem.ApplicationLogic.ViewModels.Base
{
    public class PageViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        private const int PAGE_SIZE = 20;

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

        #region Loading

        /// <summary>
        /// To show the loading bar while doing work, use this method. The loading will show when the work starts and hide when the work completes or fails.
        /// Your work (passed in the action parameter) will run on a Background thread while the Loading UI will continue on the UI Thread.
        /// <example>
        /// Example: 
        /// ShowLoading(() => 
        /// {
        ///     // Do the heavy work here.
        /// });
        /// 
        /// Alternatively you could call it like this
        /// ShowLoading(MyHeavyWorkMethod);  // All the heavy work will then be in a method called 'MyHeavyWorkMethod'
        /// </example>
        /// </summary>
        /// <param name="action">The work that needs to be done while loading is shown.</param>
        public void ShowLoading(Action action, string loadingMessage = "Loading...", double loadingDelay = 400)
        {
            action.Invoke();

            //TODO: Implement
            //this.CurrentMaster.LoadingMessage = loadingMessage;
            //this._showLoadingDelayTimer.Interval = loadingDelay;
            //this._showLoadingDelayTimer.Start(); // Shows "is busy / loading" after a delay

            //BackgroundWorker worker = new BackgroundWorker();
            //worker.DoWork += delegate(object s, DoWorkEventArgs args)
            //{
            //    // Invokes your work to be done on a background thread.
            //    action.Invoke();
            //};
            //worker.RunWorkerAsync();
            //worker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs e)
            //{
            //    // Work is complete. Hides Loading again. This will even be called when the work throws an exception.
            //    this._showLoadingDelayTimer.Stop();
            //    this.CurrentMaster.IsLoading = false;
            //};
        }

        #endregion

        #region Paging

        private PagingViewModel _pager = null;
        public PagingViewModel Pager
        {
            get
            {
                if (this._pager == null)
                {
                    this._pager = new PagingViewModel(PAGE_SIZE);
                }
                return this._pager;
            }
            set
            {
                if (value != this._pager)
                {
                    this._pager = value;
                    base.NotifyPropertyChanged("Pager");
                }
            }
        }

        #endregion
    }
}
