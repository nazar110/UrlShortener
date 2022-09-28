using System.ComponentModel.DataAnnotations;

namespace UrlShortener.DL.Entities
{
    public class UrlInfo
    {
        [Key]
        public int Id { get; set; }
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