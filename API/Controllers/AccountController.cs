using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Intefaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationOptions _applicationOptions;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(
            UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager, 
            ITokenService tokenService, 
            IMapper mapper,
            IEmailSender emailSender,
            IOptions<ApplicationOptions> optionsAccessor)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenService = tokenService;
            _mapper = mapper;
            _emailSender = emailSender;
            _applicationOptions = optionsAccessor.Value;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDto registerDto)
        {
            if (await UserExists(registerDto.UserName, registerDto.Email)) return BadRequest("Either UserName or Email is taken");

            var user = _mapper.Map<AppUser>(registerDto);

            //now managed with ASP.NET Identity
            // using var hmac = new HMACSHA512();

            user.UserName = registerDto.UserName.ToLower();
            // user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password));
            // user.PasswordSalt = hmac.Key;

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Member");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);

            return await SendConfirmationLink(user);

        }

        private async Task<ActionResult> SendConfirmationLink(AppUser user)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
         
            var callbackUrl = Url.Action(
                "ConfirmEmail",
                "Account",
                new { userId = user.Id, code },
                protocol: HttpContext.Request.Scheme);

            try
            {
                await _emailSender.SendEmailAsync(user.Email!, "AskMyCV: Account Confirmation",
                    BuildConfirmationEmailMarkup(callbackUrl));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

            return Ok( new {message = "Verification email sent. Please check your email."});
        }

        [AllowAnonymous]
        [HttpPost("resendconfirmationemail")]
        public async Task<IActionResult> ResendConfirmationEmail([FromBody] ResendConfirmationEmailDTO model)
        {
            if (model.Email != null)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || await _userManager.IsEmailConfirmedAsync(user))
                {
                    return Ok(new {message = "Email already confirmed."} );
                }

              return await SendConfirmationLink(user);

            }
            return BadRequest("Invalid model state");
        }

        private static string BuildConfirmationEmailMarkup(string? callbackUrl)
        {
            return $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }}
                    .container {{
                        width: 100%;
                        margin: 0;
                        padding: 0;
                        background-color: #f4f4f4;
                    }}
                    .header {{
                        background-color: #f4f4f4;
                        color: #333;
                        padding: 10px 0;
                        text-align: center;
                    }}
                    .content {{
                        background-color: #fff;
                        padding: 20px;
                        margin: 20px;
                        border-radius: 5px;
                    }}
                    .footer {{
                        background-color: #f4f4f4;
                        color: #333;
                        padding: 10px 0;
                        text-align: center;
                    }}
                    .button {{
                        background-color: #007bff;
                        color: white;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 5px;
                        display: inline-block;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>Confirm your email</h1>
                    </div>
                    <div class='content'>
                        <p>Thank you for registering with AskMyCV =) Your new adventure is about to start! Please confirm your email by clicking the button below.</p>
                        <a href='{callbackUrl}' class='button'>Click here to confirm your Email</a>
                    </div>
                    <div class='footer'>
                        <p>&copy; 2024 AskMyCV</p>
                    </div>
                </div>
            </body>
            </html>
            ";

        }

        private static string BuildResetPasswordEmailMarkup(string? callbackUrl)
        {
            return $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }}
                    .container {{
                        width: 100%;
                        margin: 0;
                        padding: 0;
                        background-color: #f4f4f4;
                    }}
                    .header {{
                        background-color: #f4f4f4;
                        color: #333;
                        padding: 10px 0;
                        text-align: center;
                    }}
                    .content {{
                        background-color: #fff;
                        padding: 20px;
                        margin: 20px;
                        border-radius: 5px;
                    }}
                    .footer {{
                        background-color: #f4f4f4;
                        color: #333;
                        padding: 10px 0;
                        text-align: center;
                    }}
                    .button {{
                        background-color: #007bff;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 5px;
                        display: inline-block;
                        color: white !important;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h1>Reset your password</h1>
                    </div>
                    <div class='content'>
                        <p>It seems you have forgotten your password. No worries! You can reset your password by clicking the button below.</p>
                        <a href='{callbackUrl}' class='button'>Click here to reset your password</a>
                    </div>
                    <div class='footer'>
                        <p>&copy; 2024 AskMyCV</p>
                    </div>
                </div>
            </body>
            </html>
            ";
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDto)
        {
            var user = new AppUser();
            if (!String.IsNullOrEmpty(loginDto.Email))
            {
                user = await _userManager.Users
                .Include(p => p.Photos)
                .Include(x => x.Documents)
                .Include(x => x.Employments)
                .Include(x => x.Education)
                .Include(x => x.SideProjects)
                .Include(x => x.Socials)
                .SingleOrDefaultAsync(x => x.Email == loginDto.Email.ToLower());
            }
            else 
            {
                user = await _userManager.Users
                .Include(p => p.Photos)
                .Include(x => x.Documents)
                .SingleOrDefaultAsync(x => x.UserName == loginDto.UserName.ToLower());
            }
            
            if(user.Id <= 0 || String.IsNullOrEmpty(loginDto.Password)) return Unauthorized("Invalid Credentials...");

            if (!user.EmailConfirmed)
            {
                return Unauthorized("Email not confirmed. Please check your email for the confirmation link.");
            }

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, loginDto.Password, false);

            if(!result.Succeeded) return Unauthorized("Invalid Credentials...");

            // using var hmac = new HMACSHA512(user.PasswordSalt);

            // var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            // for (int i = 0; i < computedHash.Length; i++)
            // {
            //     if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid Password");
            // }
            
            return new UserDTO
            {
                Username = user.UserName,
                KnownAs = user.KnownAs,
                Gender = user.Gender,
                Token = await _tokenService.CreateToken(user),
                PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.Url,
                Email = user.Email,
                
            };
        }

        

        [AllowAnonymous]
        [HttpPost("sendresetpasswordemail")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendResetPasswordEmail( [FromBody] ForgotPasswordDTO model)
        {
            if (model.Email != null)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    return Ok("We already sent you a password reset email. Please check your email.");
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var param = new Dictionary<string, string>
                {
                    {"token", token},
                    {"email", model.Email}
                };
                var callbackUrl = QueryHelpers.AddQueryString($"{_applicationOptions.BaseUrl}/reset-password", param);

                await _emailSender.SendEmailAsync(model.Email, "AskMyCV: Password Reset", BuildResetPasswordEmailMarkup(callbackUrl));

                return Ok(new {message = "Password reset email sent. Please check your email."} );
            }
            return BadRequest("Invalid model state");
        }


        [AllowAnonymous]
        [HttpPost("forgotpassword")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDTO model)
        {
            if (model.Email != null)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    return Ok("Password reset email sent. Please check your email.");
                }

                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action(nameof(ResetPassword), "Account", new { code }, protocol: HttpContext.Request.Scheme);

                await _emailSender.SendEmailAsync(model.Email, "Reset Password", $"Please reset your password by <a href='{callbackUrl}'>clicking here</a>.");

                return Ok("Password reset email sent. Please check your email.");
            }
            return BadRequest("Invalid model state");
        }

        [AllowAnonymous]
        [HttpPost("resetpassword")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDTO model)
        {
            if (model == null || 
                String.IsNullOrEmpty(model.Password) || 
                String.IsNullOrEmpty(model.Token) || 
                String.IsNullOrEmpty(model.Email) || 
                String.IsNullOrEmpty(model.ConfirmPassword)) 
            {
                return BadRequest("Invalid model state");
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return Ok("The password has been reset.");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token!, model.Password);
            if (result.Succeeded)
            {
                return Ok(new { message = "The password has been reset."});
            }

            return BadRequest(result.Errors);
        }

        [AllowAnonymous]
        [HttpGet("confirmemail")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return BadRequest("Invalid confirmation data");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var result = await _userManager.ConfirmEmailAsync(user, code);
            

            if (!result.Succeeded)
            {
                return BadRequest("Email confirmation failed.");
            }

            return Redirect($"{_applicationOptions.BaseUrl}/?emailConfirmed=true");
        }


        private async Task<bool> UserExists(string userName, string userEmail)
        {
            var usernameExists = await _userManager.Users.AnyAsync(x => x.UserName == userName.ToLower());
            var emailExists = await _userManager.Users.AnyAsync(x => x.Email == userEmail.ToLower());
            return usernameExists || emailExists;
        }



    }
}