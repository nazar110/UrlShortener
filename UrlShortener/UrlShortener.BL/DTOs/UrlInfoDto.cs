using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlShortener.BL.DTOs
{
    public class UrlInfoDto
    {
        public string Url { get; set; }
        public string UrlShortened { get; set; }
        /// <summary>
        /// User's login
        /// </summary>
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comment { get; set; }
    }
}
