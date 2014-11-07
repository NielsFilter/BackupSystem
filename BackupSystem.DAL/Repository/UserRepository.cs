using BackupSystem.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.DAL.Repository
{
    internal class UserRepository : IUserRepository
    {
        #region CRUD

        public void Update(User user)
        {
            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                ctx.SaveChanges();
            }
        }

        public void Add(User user)
        {
            using (BackupSystemEntities ctx = new BackupSystemEntities())
            {
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }

        #endregion

        #region List

        public IQueryable<User> GetUsers()
        {
            return new BackupSystemEntities().Users;
        }

        #endregion
    }
}
