using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BackupSystem.Domain.Validations
{
    public class ValidationBase
    {
        #region ctors
        
        public ValidationBase()
        {
            this.ValidationExceptions = null;
        }

        #endregion

        #region Properties

        private List<ValidationException> _validationExceptions;
        public List<ValidationException> ValidationExceptions { get; protected set; }

        #endregion

        public void AddException(string valExceptionMsg)
        {
            if (this.ValidationExceptions == null)
            {
                this.ValidationExceptions = new List<ValidationException>();
            }

            this.ValidationExceptions.Add(new ValidationException(valExceptionMsg));
        }
    }
}
