using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.DAL.IRepository
{
    public interface IUserRepository
    {
        void Update(User user);
        void Add(User user);
        IQueryable<User> GetUsers();
    }
}
