using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.BL.Helpers
{
    public class ShortUrlGenerator
    {
        public static string Generate(string full)
        {
            return string.Format("{0:X}", full.GetHashCode());
        }
    }
}
