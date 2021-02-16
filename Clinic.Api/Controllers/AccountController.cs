using Clinic.Api.Core.Common;
using Clinic.Api.Core.Dto;
using Clinic.Api.Core.Enums;
using Clinic.Api.Core.Interfaces;
using Clinic.Api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserCreateDto user)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ApiResponse.ValidationErrorResponse(ModelState));
            }
            if (!string.IsNullOrEmpty(user.Password))
            {
                user.Password = Cryptography.Encrypt(user.Password);
            }
            DatabaseResponse response = await _userService.CreateUserAsync(user);

            if (response.ResponseCode == (int)DbReturnValue.CreateSuccess)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.CreateSuccess));
            }
            else
            {
                return Ok(ApiResponse.OkResult(false, response.Results, DbReturnValue.RecordExists));
            }

        }
        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] UserUpdateDto user)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ApiResponse.ValidationErrorResponse(ModelState));
            }

            DatabaseResponse response = await _userService.UpdateUserAsync(user, user.Id);

            if (response.ResponseCode == (int)DbReturnValue.UpdateSuccess)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.UpdateSuccess));
            }
            else if (response.ResponseCode == (int)DbReturnValue.RecordExists)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.RecordExists));
            }
            else
            {
                return Ok(ApiResponse.OkResult(false, response.Results, DbReturnValue.NotExists));
            }

        }
 
        [HttpGet]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ApiResponse.ValidationErrorResponse(ModelState));
            }
            DatabaseResponse response = await _userService.GetUserByIdAsync(id);

            if (response.ResponseCode == (int)DbReturnValue.RecordExists)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.RecordExists));

            }
            else
            {
                return Ok(ApiResponse.OkResult(false, response.Results, DbReturnValue.NotExists));
            }

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAsync(int? roleId)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ApiResponse.ValidationErrorResponse(ModelState));
            }
            DatabaseResponse response = await _userService.GetUsersAsync(roleId);

            if (response.ResponseCode == (int)DbReturnValue.RecordExists)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.RecordExists));

            }
            else
            {
                return Ok(ApiResponse.OkResult(false, response.Results, DbReturnValue.NotExists));
            }

        }
        [HttpDelete]
        // [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ApiResponse.ValidationErrorResponse(ModelState));
            }

            DatabaseResponse response = await _userService.DeleteUserAsync(id);

            if (response.ResponseCode == (int)DbReturnValue.DeleteSuccess)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.DeleteSuccess));
            }
            else
            {
                return Ok(ApiResponse.OkResult(false, response.Results, DbReturnValue.NotExists));
            }

        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateModel model)
        {
            var user = await _userService.AuthenticateAsync(model.Username, Cryptography.Encrypt(model.Password));

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePasswordAsync([FromBody] UserPasswordDto user)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ApiResponse.ValidationErrorResponse(ModelState));
            }
            else if (user.NewPassword != user.ConfirmPassword)
            {
                return Ok(ApiResponse.OkResult(true, null, DbReturnValue.PassNotMatch));
            }
            if (!string.IsNullOrEmpty(user.NewPassword) && !string.IsNullOrEmpty(user.CurrentPassword))
            {
                user.NewPassword = Cryptography.Encrypt(user.NewPassword);
                user.CurrentPassword = Cryptography.Encrypt(user.CurrentPassword);
            }
            DatabaseResponse response = await _userService.ChangePasswordAsync(user);

            if (response.ResponseCode == (int)DbReturnValue.UpdateSuccess)
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.UpdateSuccess));
            }
            else
            {
                return Ok(ApiResponse.OkResult(true, response.Results, DbReturnValue.PassNotMatch));
            }

        }
    }
}
