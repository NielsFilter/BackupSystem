using BackupSystem.DAL;
using BackupSystem.DAL.IRepository;
using BackupSystem.Domain.IServices;
using BackupSystem.Domain.IValidations;
using BackupSystem.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupSystem.Domain.Services
{
    public class UserService : ServiceBase<IUserRepository, IUserValidation>, IUserService
    {
        #region ctors

        public UserService()
            : base()
        {
        }

        #endregion

        public void Save(bool isAdd, User user)
        {
            if (isAdd)
            {
                if (base.Validation.CanAdd(user))
                {
                    base.Repository.Add(user);
                }
            }
            else
            {
                if (base.Validation.CanUpdate(user))
                {
                    base.Repository.Update(user);
                }
            }
        }

        public IEnumerable<User> GetUsers(string searchText = null)
        {
            if (searchText == null)
            {
                searchText = string.Empty;
            }

            return base.Repository.GetUsers()
                 .Where(u => u.Username.Contains(searchText))
                 .AsEnumerable();
        }

        public User GetByUsername(string username)
        {
            return base.Repository.GetUsers()
                .FirstOrDefault(u => u.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase));
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
