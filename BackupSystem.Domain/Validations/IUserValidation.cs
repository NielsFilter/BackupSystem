using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain.IValidations
{
    public interface IUserValidation
    {
        bool CanAdd(User user);
        bool CanUpdate(User user);
        bool IsPasswordValid(User user, string password);
    }
}
