using BackupSystem.DAL;
using BackupSystem.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupSystem.Domain.Services
{
    public class ServiceBase<TRepository, TValidation>
    {
        public ServiceBase()
        {
            this.Repository = RepositoryFactory.GetRepository<TRepository>();
            this.Validation = ValidationFactory.GetValidation<TValidation>();
        }

        public TRepository Repository { get; protected set; }
        public TValidation Validation { get; protected set; }
    }
}
