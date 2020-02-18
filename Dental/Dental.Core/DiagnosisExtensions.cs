using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Dental.Core
{
    public static class DiagnosisExtensions
    {
        public static IList<KeyValuePair<int, string>> ToList(this Type input)
        {
            var dictionary = new List<KeyValuePair<int, string>>();

             var values = Enum.GetValues(input);

            foreach (var value in values)
            {
                var val = (Enum)value;

                dictionary.Add(new KeyValuePair<int, string>(Convert.ToInt32(value), val.GetDesc()));
            }

            return dictionary;
        }


        public static string GetDesc(this Enum input)
        {
            var type = input.GetType();

            if (!type.IsEnum)
                return string.Empty;

            var memInfo = type.GetMember(input.ToString());

            if (memInfo.Length <= 0)
                return input.ToString();

            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? ((DescriptionAttribute)attributes[0]).Description : input.ToString();
        }
    }
}
