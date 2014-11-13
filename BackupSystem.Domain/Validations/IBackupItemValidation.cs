using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain.Validations
{
    public interface IBackupItemValidation
    {
        bool CanAdd(BackupItem backupItem);
        bool CanUpdate(BackupItem backupItem);
        bool CanDelete(BackupItem backupItem);
    }
}
