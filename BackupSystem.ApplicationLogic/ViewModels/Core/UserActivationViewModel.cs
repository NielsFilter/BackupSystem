using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.Common.Mvvm.Commands;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Core
{
    public class UserActivationViewModel : PageViewModel
    {
        #region Constructors

        public UserActivationViewModel()
            : base()
        {

        }

        #endregion

        #region Properties

        private string _code;
        public string Code
        {
            get
            {
                if (this._code == null)
                {
                    return null;
                }
                return this._code.ToUpper();
            }
            set
            {
                if (value != this._code)
                {
                    this._code = value;
                    base.NotifyPropertyChanged("Code");
                }
            }
        }

        private string _currentLicense;
        public string CurrentLicense
        {
            get
            {
                return this._currentLicense;
            }
            set
            {
                if (value != this._currentLicense)
                {
                    this._currentLicense = value;
                    base.NotifyPropertyChanged("CurrentLicense");
                }
            }
        }

        public IEnumerable<string> UsedLicenseCodes
        {
            get
            {
                return getUsedLicenses();
            }
        }

        #endregion

        #region Load

        public override void OnLoad()
        {
            base.OnLoad();

            this.readCurrentLicense();
        }

        public override void OnRefresh()
        {
            base.OnRefresh();
        }

        #endregion

        #region Activate License

        public void ActivateLicense()
        {
            if (string.IsNullOrEmpty(this.Code) || this.UsedLicenseCodes.Contains(this.Code))
            {
                return;
            }

            //TODO: Implement
            //string invalidCodeMsg = "The code you have entered is invalid. Please make sure that you have entered it correctly.";
            //try
            //{
            //    var updatedLicense = License.ApplyLicenseCode(this.Code);
            //    string xml = XML.Serialize(updatedLicense);

            //    var lic = this.Db.Licenses.FirstOrDefault();
            //    if (lic == null)
            //    {
            //        lic = new Data.License();
            //    }

            //    lic.Code = Security.Encrypt(xml, SessionContext.Current.ClientCode);
            //    lic.IsActive = true;

            //    var usedLic = new ActiveLicense();
            //    usedLic.AppliedDate = DateTime.Now;
            //    usedLic.Code = this.Code;
            //    this.Db.ActiveLicenses.AddObject(usedLic); // Add the license Keys to the used list. Prevents reuse.
            //    this.Db.SaveChanges();

            //    // License updated successfully
            //    License.Evaluate();
            //    readCurrentLicense();
            //}
            //catch (Exception)
            //{
            //    base.DialogService.ShowMessageBox(this, invalidCodeMsg, "Invalid Code", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
            //}
        }

        private void readCurrentLicense()
        {
            //TODO: Implement
            //var lic = this.Db.Licenses.FirstOrDefault();
            //if (lic == null)
            //{
            //    this.CurrentLicense = "No license";
            //}

            //this.CurrentLicense = lic.CurrentLicenseText;
        }

        #endregion

        private IEnumerable<string> getUsedLicenses()
        {
            //TODO: Implement
            //this.Db.ActiveLicenses.Select(al => al.Code.ToUpper());
            return null;
        }
    }
}
