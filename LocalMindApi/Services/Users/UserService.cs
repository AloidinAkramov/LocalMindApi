using LocalMindApi.DTOs;
using LocalMindApi.Helpers.LocalMindApi.Helpers;
using LocalMindApi.Models.Users;
using LocalMindApi.Repositories.UserAdditionalDetails;
using LocalMindApi.Repositories.Users;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserAdditionalDetailRepository userAdditionalDetailRepository;

        public UserService(
            IUserRepository userRepository,
            IUserAdditionalDetailRepository userAdditionalDetailRepository)
        {
            this.userRepository = userRepository;
            this.userAdditionalDetailRepository = userAdditionalDetailRepository;
        }

        public async ValueTask<UserDto> AddUserAsync(UserDto userDto)
        {
            User user = MapToUser(userDto);
            user.HashedPassword = HashingHelper.GetHash(userDto.Password);

            await this.userRepository.InsertUserAsync(user);

            if (user.UserAdditionalDetail != null)
            {
                await this.userAdditionalDetailRepository
                    .InsertUserAdditionalDetailAsync(user.UserAdditionalDetail);
            }

            return userDto;
        }

        public IQueryable<UserDto> RetrieveAllUsers()
        {
            return this.userRepository.SelectAllUsers()
                .Select(MapToUserDto).AsQueryable();
        }

        private static User MapToUser(UserDto userDto)
        {
            DateTimeOffset now = DateTimeOffset.UtcNow;
            Guid newId = Guid.NewGuid();

            return new User
            {
                Id = newId,
                Username = userDto.Username,
                HashedPassword = userDto.Password,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                PhoneNuber = userDto.PhoneNuber,
                Role = userDto.Role,
                CreatedDate = now,
                UpdatedDate = now,
                UserAdditionalDetail = userDto.UserAdditionalDetail
            };
        }

        private static UserDto MapToUserDto(User user)
        {
            return new UserDto
            {
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNuber = user.PhoneNuber,
                Role = user.Role,
                UserAdditionalDetail = user.UserAdditionalDetail
            };
        }
    }
}