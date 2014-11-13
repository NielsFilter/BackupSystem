using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain.IServices
{
    public interface IBackupItemService
    {
        ObservableCollection<BackupItem> GetBackupItems(string searchText);
        void Save(bool isAdd, BackupItem backupItem);
        void Delete(BackupItem backupItem);
    }
}
