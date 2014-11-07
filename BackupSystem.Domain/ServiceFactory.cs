using BackupSystem.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Domain
{
    public class ServiceFactory
    {
        public static TInterface GetService<TInterface>()
        {
            var types = ReflectionHelper.GetByInterface<TInterface>(Assembly.GetExecutingAssembly());
            return (TInterface)Activator.CreateInstance(types.FirstOrDefault());
        }   
    }
}
