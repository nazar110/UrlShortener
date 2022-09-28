using System.ComponentModel.DataAnnotations;

namespace UrlShortener.DL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"[\w\d.@]{6,}", ErrorMessage = "Login must be at least 6 symbols length, contain one or more character and number. Allowed special symbols: '.', '@'")]
        public string Login { get; set; }
        [RegularExpression(@"[\w\d._]{6,}", ErrorMessage = "Password must be at least 6 symbols length, contain one or more character and number. Allowed special symbols: '.', '_'")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
