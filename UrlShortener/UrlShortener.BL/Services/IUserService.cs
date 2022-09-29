using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.BL.DTOs;

namespace UrlShortener.BL.Services
{
    public interface IUserService
    {
        UserDto Get(string login, string password);
        void Add(UserDto userDto);
        void Update(UserDto userDto);
        void Remove(UserDto userDto);
    }
}
