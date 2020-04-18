using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Config
    {
        public static CultureInfo Culture()
        {
            var ci = CultureInfo.GetCultureInfo(Constants.CultureLocale);
            return ci;
        }
    }
}
