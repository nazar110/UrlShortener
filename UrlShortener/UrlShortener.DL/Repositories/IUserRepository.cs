using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.DL.Entities;

namespace UrlShortener.DL.Repositories
{
    public interface IUserRepository
    {
        User Get(string login, string password);
        void Add(User user);
        void Update(User user);
        void Remove(User user);
        public void Save();
    }
}
