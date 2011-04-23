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
        public static IList<string> LlenarComboNombresMes(CultureInfo culture)
        {
            var list = new List<string>();

            for (int i = 1; i <= 12; i++)
            {
                list.Add(culture.TextInfo.ToTitleCase(culture.DateTimeFormat.GetMonthName(i)));
            }

            return list;
        }
    }

}
