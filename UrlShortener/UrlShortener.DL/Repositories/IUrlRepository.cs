using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.DL.Entities;

namespace UrlShortener.DL.Repositories
{
    public interface IUrlRepository
    {
        UrlInfo Get(string shortenUrl);
        List<UrlInfo> GetAll();
        void Add(UrlInfo urlInfo);
        void Update(UrlInfo urlInfo);
        void Remove(UrlInfo urlInfo);
        void Save();
    }
}
