using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.BL.Helpers
{
    public class Cipher
    {
        public static string Encode(string password)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(password));
        }
        public static string Decode(string encodedPassword)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(encodedPassword));
        }
    }
}
