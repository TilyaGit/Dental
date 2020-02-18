using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dental.Core
{
    public class Patient
    {
        protected Patient()
        {
            MedicationHistories = new List<Medication>();
        }

        public Patient(
            [NotNull] string firstName,
            [NotNull] string secondName,
            [NotNull] string thirdName,
            [NotNull] string phoneNumber,
            DateTime birthDay) : this()
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException(nameof(firstName));

            if (string.IsNullOrEmpty(secondName))
                throw new ArgumentNullException(nameof(secondName));
            if (string.IsNullOrEmpty(thirdName))
                throw new ArgumentException(nameof(thirdName));

            if (string.IsNullOrEmpty(phoneNumber))
                throw new ArgumentNullException(nameof(phoneNumber));

            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            PhoneNumber = phoneNumber;
            BirthDay = birthDay;
        }

        public long Id { get; protected set; }

        public string FirstName { get;  set; }

        public string SecondName { get;  set; }

        public string ThirdName { get; set; }

        public DateTime BirthDay { get;  set; }

        public string PhoneNumber { get;  set; }

        public IList<Medication> MedicationHistories { get; protected set; }

        public void With(
            [CanBeNull] string firstName = null,
            [CanBeNull] string secondName = null,
            [CanBeNull] string thirdName = null,
            [CanBeNull] string phoneNumber = null,
            DateTime? birthDay = null)
        {
            FirstName = firstName ?? FirstName;
            SecondName = secondName ?? SecondName;
            ThirdName = thirdName ?? ThirdName;
            PhoneNumber = phoneNumber ?? PhoneNumber;
            BirthDay = birthDay ?? BirthDay;
        }

        public void AddSick(Medication sick)
        {
            if (sick == null)
                throw new ArgumentNullException(nameof(sick));

            MedicationHistories.Add(sick);
        }
        public void DeleteSick(int medicationId)
        {
            var deletedMedication = MedicationHistories.First(d => d.Id == medicationId);
            MedicationHistories.Remove(deletedMedication);
        }
    }
}