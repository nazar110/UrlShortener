using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.BL.DTOs;

namespace UrlShortener.BL.Services
{
    public interface IUrlService
    {
        // string GetFullBy(string shortenUrl);
        UrlInfoDto GetBy(string shortenUrl);
        List<UrlInfoDto> GetAll();
        UrlInfoDto Add(string fullUrl, string login);
        UrlInfoDto Remove(string shortenUrl, string login, string password);
        UrlInfoDto Update(UrlInfoDto urlToUpdate);

    }
}
