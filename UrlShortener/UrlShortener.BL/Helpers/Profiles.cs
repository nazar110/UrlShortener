using AutoMapper;
using UrlShortener.BL.DTOs;
using UrlShortener.DL.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UrlShortener.BL.Helpers
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<UrlInfo, UrlInfoDto>(); // for get
            CreateMap<UrlInfoDto, UrlInfo>(); // for create and update
            CreateMap<User, UserDto>(); // for get
            CreateMap<UserDto, User>(); // for create and update
        }
    }
}
