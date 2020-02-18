using JetBrains.Annotations;
using System;

namespace Dental.Core
{
    public class Doctor
    {
        public Doctor()
        {
        }
        public Doctor(
                     [NotNull] string firstName,
                     [NotNull] string secondName,
                     [NotNull] string thirdName,
                     [NotNull] string phoneNumber,
                     DateTime birthDay
                    ) : this()
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
    }
}
