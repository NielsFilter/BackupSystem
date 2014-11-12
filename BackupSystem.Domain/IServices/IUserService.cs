using BackupSystem.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain.IServices
{
    public interface IUserService
    {
        ObservableCollection<User> GetUsers(string searchText);
        void Save(bool isAdd, User user);
        User GetByUsername(string username);
        User LoginUser(string username, string password);
    }
}
