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
    }
}
