using BackupSystem.DAL;
using BackupSystem.Domain.IValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain.Validations
{
    public class BackupItemValidation : ValidationBase, IBackupItemValidation
    {
        public BackupItemValidation()
            : base()
        {
        }

        public bool CanAdd(BackupItem backupItem)
        {
            return this.saveValidations(backupItem);
        }

        public bool CanUpdate(BackupItem backupItem)
        {
            return this.saveValidations(backupItem);
        }

        #region Private Methods

        private bool saveValidations(BackupItem backupItem)
        {
            // TODO: Validations
            return true;
        }

        public bool CanDelete(BackupItem backupItem)
        {
            // TODO: Validations
            return true;
        }

        #endregion
    }
}
