using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.DL.Entities;

namespace UrlShortener.DL.Helpers
{
    public class SeedData
    {
        public static void Seed(UrlShortenerContext context)
        {
            context.Users.Add(new User()
            {
                Login = "admin1",
                Password = "qwerty1",
                IsAdmin = true
            });
            context.SaveChanges();
        }
    }
}
