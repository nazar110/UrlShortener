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
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UrlService(IUrlRepository urlRepository, IUserRepository userRepository, IMapper mapper)
        {
            _urlRepository = urlRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UrlInfoDto Add(string fullUrl, string login)
        {
            var createdRecord = new UrlInfoDto()
            {
                Url = fullUrl,
                UrlShortened = ShortUrlGenerator.Generate(fullUrl),
                CreatedDate = DateTime.UtcNow,
                CreatedBy = login,
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

        public UrlInfoDto Remove(string shortenUrl, string login, string password)
        {
            var user = _userRepository.Get(login, Cipher.Encode(password));
            if (user == null)
            {
                throw new ArgumentException("Such user wasn't found");
            }
            var urlToDelete = _urlRepository.Get(shortenUrl);
            _urlRepository.Remove(urlToDelete);
            _urlRepository.Save();
            return _mapper.Map<UrlInfoDto>(urlToDelete);
        }

        public UrlInfoDto Update(UrlInfoDto urlToUpdate)
        {
            _urlRepository.Update(_mapper.Map<UrlInfo>(urlToUpdate));
            _urlRepository.Save();
            return urlToUpdate;
        }
    }
}