using BackupSystem.DAL;
using BackupSystem.Domain.IServices;
using BackupSystem.Domain.IValidations;
using BackupSystem.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading;

namespace BackupSystem.Domain.Services
{
    public class BackupItemService : ServiceBase<IBackupItemValidation>, IBackupItemService
    {
        #region ctors

        public BackupItemService()
            : base()
        {
        }

        #endregion

        public ObservableCollection<BackupItem> GetBackupItems(string searchText)
        {
            if (searchText == null)
            {
                searchText = string.Empty;
            }
            searchText = searchText.Trim();

            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                return ctx.BackupItems.Where(bi => bi.Name.Contains(searchText) && bi.IsActive).AsObservableCollection();
            }
        }

        public void Save(bool isAdd, BackupItem backupItem)
        {
            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                if (isAdd && base.Validation.CanAdd(backupItem))
                {
                    // Add
                    ctx.BackupItems.Add(backupItem);
                    ctx.SaveChanges();
                }
                else if (base.Validation.CanUpdate(backupItem))
                {
                    // Update
                    ctx.SaveChanges();
                }
            }
        }

        public void Delete(BackupItem backupItem)
        {
            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                if (base.Validation.CanDelete(backupItem))
                {
                    ctx.BackupItems.Attach(backupItem);
                    ctx.BackupItems.Remove(backupItem);
                    ctx.SaveChanges();
                }
            }
        }
    }
}
