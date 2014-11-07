using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain.IServices
{
    public interface IUserService
    {
        void Save(bool isAdd, User user);
        IEnumerable<User> GetUsers(string searchText = null);
        User GetByUsername(string username);
        User LoginUser(string username, string password);
    }
}
