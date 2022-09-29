using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.DL.Entities;

namespace UrlShortener.DL.Repositories
{
    public class UrlRepository : IUrlRepository
    {
        private readonly UrlShortenerContext _context;

        public UrlRepository()
        {
            _context = new UrlShortenerContext();
        }
        public void Add(UrlInfo urlInfo)
        {
            _context.UrlInfo.Add(urlInfo);
        }

        public UrlInfo Get(string shortenUrl)
        {
            return _context.UrlInfo.Where(url => url.UrlShortened == shortenUrl).FirstOrDefault();
        }

        public List<UrlInfo> GetAll()
        {
            return _context.UrlInfo.ToList();
        }

        public void Remove(UrlInfo urlInfo)
        {
            var existent = _context.UrlInfo.Where(url => url.Id == urlInfo.Id).FirstOrDefault();
            if (existent != null)
            {
                _context.Remove(existent);
            }
        }

        public void Update(UrlInfo urlInfo)
        {
            _context.UrlInfo.Update(urlInfo);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
