using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace Dental.Core
{
    public class Medication
    {
        protected Medication()
        {
            Images = new List<MedicationImage>();
        }

        public Medication([NotNull] string plan, Diagnosis diagnosis) : this()
        {
            Plan = plan ?? throw new ArgumentNullException(nameof(plan));
            Diagnosis = diagnosis;
        }

        public int Id { get; protected set; }

        public string Plan { get;  set; }

        public Doctor Doctors { get; set; }

        public Diagnosis Diagnosis { get;  set; }

        public ServiceCategory ServiceCategory { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IList<MedicationImage> Images { get; protected set; }


        public void AddImage(string name, byte[] image)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (image == null) throw new ArgumentNullException(nameof(image));

            var medicationImage = new MedicationImage(name, image);
            Images.Add(medicationImage);
        }
    }
}