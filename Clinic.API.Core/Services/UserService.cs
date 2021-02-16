using AutoMapper;
using Clinic.Api.Core.Dto;
using Clinic.Api.Core.Entities;
using Clinic.Api.Core.Enums;
using Clinic.Api.Core.Interfaces;
using Clinic.Api.Core.Specifications;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IAsyncRepository<User> _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public UserService(IAsyncRepository<User> userRepository, IMapper mapper, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<UserDto> AuthenticateAsync(string username, string password)
        {
            var userSpec = new UserFilterSpecification(username, password);
            var user = await _userRepository.GetByIdAsync(userSpec);
            UserDto userDto = new UserDto();
            userDto = _mapper.Map(user, userDto);
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("AppSettings").GetSection("Secret").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role,userDto.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Audience = _configuration.GetSection("AppSettings").GetSection("Audience").Value,//<string>("AppSettings:Audience"),
                Issuer = _configuration.GetSection("AppSettings").GetSection("Issuer").Value,// _configuration.GetValue<string>("AppSettings:Issuer")
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            userDto.Token = tokenHandler.WriteToken(token);
            return userDto;
        }

        public async Task<DatabaseResponse> ChangePasswordAsync(UserPasswordDto userDto)
        {
            User user = await _userRepository.GetByIdAsync(userDto.UserId);
            user.ModifiedDate = DateTime.Now;
            user.Password = userDto.NewPassword;
           // var updateUser = _mapper.Map(userDto, user);
            await _userRepository.UpdateAsync(user);
            int status = 0;
            status = (int)DbReturnValue.UpdateSuccess;

            return new DatabaseResponse { ResponseCode = status };
        }

        public Task<DatabaseResponse> CheckValidUserAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> ConfirmVerificationToken(string token)
        {
            throw new NotImplementedException();
        }

        public async Task<DatabaseResponse> CreateUserAsync(UserCreateDto user)
        {

            int status = 0;
            var filterSpecification = new UserFilterSpecification(user.RoleId, user.Email);

            var userExists = await _userRepository.ListAsync(filterSpecification);

            if (userExists.Count == 0)
            {
                var addUser = _mapper.Map<User>(user);
                addUser.CreatedDate = DateTime.Now;
                var result = await _userRepository.AddAsync(addUser);
                if (result.Id != 0)
                {
                    status = (int)DbReturnValue.CreateSuccess;
                }
            }
            else
            {
                status = (int)DbReturnValue.RecordExists;
            }
            return new DatabaseResponse { ResponseCode = status };
        }

        public async Task<DatabaseResponse> DeleteUserAsync(int userId)
        {
            int status = 0;

            User user = await _userRepository.GetByIdAsync(userId);
      
            if (user == null)
            {
                status = (int)DbReturnValue.NotExists;
            }
            else
            {
                int affectedrows = await _userRepository.DeleteAsync(user);

                if (affectedrows > 0)
                {
                    status = (int)DbReturnValue.DeleteSuccess;
                }
                else
                {
                    status = (int)DbReturnValue.NotExists;
                }
            }
            return new DatabaseResponse { ResponseCode = status };
        }

        public Task<DatabaseResponse> ForgotPasswordAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DatabaseResponse> GetUserByIdAsync(int userId)
        {
            var filterSpecification = new UserFilterSpecification(userId);

            var user = await _userRepository.GetByIdAsync(filterSpecification);
            var result = _mapper.Map<UserDto>(user);
            int status = 0;
            if (user != null)
            {
                status = (int)DbReturnValue.RecordExists;
            }
            else
            {
                status = (int)DbReturnValue.NotExists;
            }

            return new DatabaseResponse { ResponseCode = status, Results = result };
        }

        public async Task<DatabaseResponse> GetUsersAsync(int? RoleId)
        {
            var userSpec = new UserFilterSpecification(RoleId,0);
            var users = await _userRepository.ListAsync(userSpec);
            int status = 0;
            status = (int)DbReturnValue.RecordExists;
            return new DatabaseResponse { ResponseCode = status, Results = users };
        }

        public async Task<DatabaseResponse> UpdateUserAsync(UserUpdateDto userDto, int userId)
        {
            User user = await _userRepository.GetByIdAsync(userId);
            userDto.ModifiedDate = DateTime.Now;
            var updateUser = _mapper.Map(userDto, user);
            await _userRepository.UpdateAsync(updateUser);
            int status = 0;
            status = (int)DbReturnValue.UpdateSuccess;

            return new DatabaseResponse { ResponseCode = status };
        }
    }
}
