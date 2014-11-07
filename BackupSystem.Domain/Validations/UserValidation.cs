using BackupSystem.DAL;
using BackupSystem.Domain.IValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackupSystem.Common.Utils;

namespace BackupSystem.Domain.Validations
{
    public class UserValidation : ValidationBase, IUserValidation
    {
        public UserValidation()
            : base()
        {
        }

        public bool CanAdd(User user)
        {
            return saveValidations(user);
        }

        public bool CanUpdate(User user)
        {
            return saveValidations(user);
        }

        public bool IsPasswordValid(User user, string password)
        {
            try
            {
                var correctPassword = user.Password;
                var encPass = password.Encrypt("filterniels");
                return encPass == correctPassword;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #region Private Methods

        private bool saveValidations(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                base.AddException("Username is required");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                base.AddException("Password is required");
            }

            if (user.Password.Length < 5)
            {
                base.AddException("Password must be at least 5 characters");
            }

            return !base.ValidationExceptions.Any();
        }

        #endregion

    }
}
