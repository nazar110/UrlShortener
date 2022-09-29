using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.BL.DTOs;
using UrlShortener.DL.Entities;
using UrlShortener.DL.Repositories;

namespace UrlShortener.BL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Add(UserDto userDto)
        {
            _userRepository.Add(_mapper.Map<User>(userDto));
            _userRepository.Save();
        }

        public UserDto Get(string login, string password)
        {
            var user = _mapper.Map<UserDto>(_userRepository.Get(login, password));
            _userRepository.Save();
            return user;
        }

        public void Remove(UserDto userDto)
        {
            _userRepository.Remove(_mapper.Map<User>(userDto));
            _userRepository.Save();
        }

        public void Update(UserDto userDto)
        {
            _userRepository.Update(_mapper.Map<User>(userDto));
            _userRepository.Save();
        }
    }
}
