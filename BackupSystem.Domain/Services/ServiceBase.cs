using BackupSystem.DAL;
using BackupSystem.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupSystem.Domain.Services
{
    public class ServiceBase<TValidation>
    {
        public ServiceBase()
        {
            this.Validation = ValidationFactory.GetValidation<TValidation>();
        }

        public TValidation Validation { get; protected set; }
    }
}
