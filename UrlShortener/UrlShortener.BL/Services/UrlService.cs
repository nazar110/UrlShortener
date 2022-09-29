using AutoMapper;
using UrlShortener.BL.DTOs;
using UrlShortener.BL.Helpers;
using UrlShortener.DL.Entities;
using UrlShortener.DL.Repositories;

namespace UrlShortener.BL.Services
{
    public class UrlService : IUrlService
    {
        private readonly IUrlRepository _urlRepository;
        private readonly IMapper _mapper;
        public UrlService(IUrlRepository urlRepository, IMapper mapper)
        {
            _urlRepository = urlRepository;
            _mapper = mapper;
        }

        public UrlInfoDto Add(string fullUrl)
        {
            var createdRecord = new UrlInfoDto()
            {
                Url = fullUrl,
                UrlShortened = ShortUrlGenerator.Generate(fullUrl),
                CreatedDate = DateTime.UtcNow,
                CreatedBy = "User name",
                Comment = "None"
            };

            _urlRepository.Add(_mapper.Map<UrlInfo>(createdRecord));
            _urlRepository.Save();
            return createdRecord;
        }

        public List<UrlInfoDto> GetAll()
        {
            var records = _urlRepository.GetAll();
            return _mapper.Map<List<UrlInfoDto>>(records);
        }

        public UrlInfoDto GetBy(string shortenUrl)
        {
            var record = _urlRepository.Get(shortenUrl);
            return _mapper.Map<UrlInfoDto>(record);
        }

        public UrlInfoDto Remove(string shortenUrl, string userName)
        {
            
        }

        public UrlInfoDto Update(UrlInfoDto urlToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}