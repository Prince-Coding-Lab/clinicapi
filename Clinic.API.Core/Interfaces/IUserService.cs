﻿using Clinic.Api.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Interfaces
{
    public interface IUserService
    {
        Task<DatabaseResponse> CreateUserAsync(UserCreateDto user);
        Task<DatabaseResponse> UpdateUserAsync(UserUpdateDto user, int userId);
        Task<DatabaseResponse> GetUserByIdAsync(int userId);
        Task<DatabaseResponse> GetUsersAsync(int? RoleId);
        Task<DatabaseResponse> DeleteUserAsync(int userId);
        Task<DatabaseResponse> ForgotPasswordAsync();
        Task<DatabaseResponse> ChangePasswordAsync(UserPasswordDto user);
      //  Task<DatabaseResponse> ResetPasswordAsync(ResetPasswordDto user);
        Task<UserDto> AuthenticateAsync(string username, string password);
        Task<DatabaseResponse> CheckValidUserAsync(string email);
       // Task CreateVerificationTokenAsync(VerificationTokenDto verifyRequest);

        Task<DatabaseResponse> ConfirmVerificationToken(string token);

       // Task<DatabaseResponse> ActivateEmail(VerificationTokenDto model);
    }
}
