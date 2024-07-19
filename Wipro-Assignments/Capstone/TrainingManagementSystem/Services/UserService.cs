using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using TrainingManagementSystem.DTOs;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Repositories;

namespace TrainingManagementSystem.Services
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

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<User> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = _mapper.Map<User>(createUserDto);
            user.Password = createUserDto.Password;

            return await _userRepository.CreateUserAsync(user);
        }

        public async Task<bool> UpdateUserAsync(int id, UpdateUserDto updateUserDto)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null) return false;

            _mapper.Map(updateUserDto, user);
            return await _userRepository.UpdateUserAsync(user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteUserAsync(id);
        }
    }

    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(CreateUserDto createUserDto);
        Task<bool> UpdateUserAsync(int id, UpdateUserDto updateUserDto);
        Task<bool> DeleteUserAsync(int id);
    }
}
