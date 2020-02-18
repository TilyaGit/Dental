using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core
{
     public class ServiceCategory
    {
        public ServiceCategory()
        {
        }
        public ServiceCategory(
                              [NotNull] string name, 
                              [NotNull] string desscribe
                              ) : this()
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(desscribe))
                throw new ArgumentNullException(nameof(desscribe));

            Name = name;
            Desscribe = desscribe;
        }

        public int Id { get; protected set; }
        public string Name { get; set; }
        public string Desscribe { get; set; }
       
    }
}
