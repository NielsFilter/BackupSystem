using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackupSystem.Common.Utils
{
    public class ReflectionHelper
    {
        /// <summary>
        /// Gets all the types implementing <see cref="TInterface"/>
        /// </summary>
        /// <example>
        /// If you call ReflectionHelper.GetByInterface<IDashboardNotification>(Assembly.GetCallingAssembly()), all the types (classes or structs)
        /// that implement 
        /// </example>
        /// <typeparam name="TInterface">Type of interface</typeparam></typeparam>
        /// <param name="assembly">The Assembly in which to find the classes implementing the interface.</param>
        /// <exception cref="ArgumentNullException"/>Thrown if assembly is null.</exception>
        /// <exception cref="ArgumentException"/>Thrown if TInterface is not an interface.</exception>
        /// <returns></returns>
        /// <
        public static IEnumerable<Type> GetByInterface<TInterface>(Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            if (!typeof(TInterface).IsInterface)
            {
                throw new ArgumentException(string.Format("'{0}' is not an interface. Method expects Generic to be an interface.", typeof(TInterface)));
            }

            return assembly
                .GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i == typeof(TInterface)));
        }
    }
}
