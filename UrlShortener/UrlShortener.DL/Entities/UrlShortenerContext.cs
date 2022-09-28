using Microsoft.EntityFrameworkCore;
using UrlShortener.DL.Helpers;

namespace UrlShortener.DL.Entities
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext()
        {

        }
        public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options)
        {
            bool newlyCreated = Database.EnsureCreated();
            if (newlyCreated)
            {
                try
                {
                    SeedData.Seed(this);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR. Failed to seed data users");
                    string error = @$"Error Message: {ex.Message}\n
                                    StackTrace: {ex.StackTrace}\n";
                    Console.WriteLine(error);
                    Console.WriteLine(@$"Error was saved to {AppDomain.CurrentDomain.BaseDirectory}\errors.txt");
                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\errors.txt", error);
                }
            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UrlInfo> UrlInfo { get; set; }
    }
}
