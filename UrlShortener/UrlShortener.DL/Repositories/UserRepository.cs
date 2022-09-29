using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.DL.Entities;

namespace UrlShortener.DL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UrlShortenerContext _context;
        public UserRepository(UrlShortenerContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
        }

        public User Get(string login, string password)
        {
            var user = _context.Users
                .Where(usr => usr.Login == login && usr.Password == password)
                .FirstOrDefault();
            return user;
        }

        public void Remove(User user)
        {
            var existent = _context.Users
                .Where(usr => usr.Login == user.Login && usr.Password == user.Password)
                .FirstOrDefault();
            
            if (existent != null)
            {
                _context.Users.Remove(existent);
            }
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
