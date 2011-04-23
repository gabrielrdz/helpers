using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace GR7
{
    public static class Helpers
    {
        /// <summary>
        /// Gets the list of all 12 months for the given culture, Title Cased
        /// </summary>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static IList<string> GetMonthNamesFromCulture(CultureInfo culture)
        {
            var list = new List<string>();

            for (int i = 1; i <= 12; i++)
            {
                list.Add(culture.TextInfo.ToTitleCase(culture.DateTimeFormat.GetMonthName(i)));
            }

            return list;
        }

        /// <summary>
        /// Returns the month name of the given month for the passed culture
        /// </summary>
        /// <param name="culture"></param>
        /// <param name="monthNumber"></param>
        /// <returns></returns>
        public static string GetMonthName(CultureInfo culture, int monthNumber)
        {
            if (culture == null || monthNumber < 1 || monthNumber > 12) return string.Empty;

            return culture.TextInfo.ToTitleCase(culture.DateTimeFormat.GetMonthName(monthNumber));
        }
    }

}
