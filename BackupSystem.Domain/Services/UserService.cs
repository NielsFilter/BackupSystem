using BackupSystem.DAL;
using BackupSystem.Domain.IServices;
using BackupSystem.Domain.IValidations;
using BackupSystem.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BackupSystem.Domain.Services
{
    public class UserService : ServiceBase<IUserValidation>, IUserService
    {
        #region ctors

        public UserService()
            : base()
        {
        }

        #endregion

        public ObservableCollection<User> GetUsers(string searchText)
        {
            if (searchText == null)
            {
                searchText = string.Empty;
            }

            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                return ctx.Users.Where(u => u.Username.Contains(searchText.Trim()) && u.IsActive).AsObservableCollection();
            }
        }

        public void Save(bool isAdd, User user)
        {
            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                if (isAdd && base.Validation.CanAdd(user))
                {
                    // Add
                    ctx.Users.Add(user);
                    ctx.SaveChanges();
                }
                else if (base.Validation.CanUpdate(user))
                {
                    // Update
                    ctx.SaveChanges();
                }
            }
        }

        public User GetByUsername(string username)
        {
            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                return ctx.Users
                    .FirstOrDefault(u => u.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) && u.IsActive);
            }
        }

        public User LoginUser(string username, string password)
        {
            var user = this.GetByUsername(username);
            if (user != null)
            {
                if (base.Validation.IsPasswordValid(user, password))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
