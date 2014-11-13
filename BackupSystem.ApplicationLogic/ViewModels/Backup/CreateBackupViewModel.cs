using BackupSystem.ApplicationLogic.ViewModels.Base;
using BackupSystem.Common.Mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.ApplicationLogic.ViewModels.Backup
{
    public class CreateBackupViewModel : PageViewModel
    {
        #region ctors

        public CreateBackupViewModel(IParentViewModel parentVM)
            : base(parentVM)
        {

        }

        #endregion

        #region Properties



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
    }
}
