using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.Common.Enums;
using BackupSystem.Common.Licensing;
using BackupSystem.Common.Mvvm.ViewModels;
using BackupSystem.Common.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BackupSystem.ApplicationLogic.ViewModels.Tools
{
    public class ActivationKeyGeneratorViewModel : PageViewModel
    {
        #region Constructors

        public ActivationKeyGeneratorViewModel(IParentViewModel parentVM)
            : base(parentVM)
        {

        }

        #endregion

        #region Properties

        private string _activationKey;
        public string ActivationKey
        {
            get
            {
                return this._activationKey;
            }
            set
            {
                if (value != this._activationKey)
                {
                    this._activationKey = value;
                    base.NotifyPropertyChanged("ActivationKey");
                }
            }
        }

        private ActivationCode _activation;
        public ActivationCode Activation
        {
            get
            {
                return this._activation;
            }
            set
            {
                if (value != this._activation)
                {
                    this._activation = value;
                    base.NotifyPropertyChanged("Activation");
                }
            }
        }

        private IEnumerable<PeriodType> _periods;
        public IEnumerable<PeriodType> Periods
        {
            get
            {
                return this._periods;
            }
            set
            {
                if (value != this._periods)
                {
                    this._periods = value;
                    base.NotifyPropertyChanged("Periods");
                }
            }
        }

        #endregion

        #region Load

        public override void OnLoad()
        {
            base.OnLoad();

            this.Activation = new ActivationCode();
            this.Periods = Enum.GetValues(typeof(PeriodType)).Cast<PeriodType>();
        }

        public override void OnRefresh()
        {
            base.OnRefresh();
        }

        #endregion

        #region Generate Activation Key

        private bool canGenerateKey()
        {
            if (string.IsNullOrEmpty(this.Activation.ClientCode))
                return false;

            if (this.Activation.IsExpiryMode)
            {
                return this.Activation.ExpiryDate > DateTime.Today;
            }
            else
            {
                return this.Activation.Extension > 0;
            }
        }

        public void GenerateKey()
        {
            if (!canGenerateKey())
            {
                return; 
            }

            //TODO: Continue HERE - Add Apply license functionality
            this.ActivationKey = Security.CreateCode(this.Activation);

            var test = Security.ReadCode(this.ActivationKey);
        }

        #endregion
    }
}
