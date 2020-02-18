using JetBrains.Annotations;
using System;

namespace Dental.Core
{
    public  class MedicationImage
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public byte[] Image { get; protected set; }

        protected MedicationImage() { }

        public MedicationImage([NotNull] string name, [NotNull] byte[] image)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Image = image ?? throw new ArgumentNullException(nameof(image));
        }    
    }
}