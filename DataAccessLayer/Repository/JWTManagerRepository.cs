using DataAccessLayer.Repository.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.Dto_Model;
using Models.Entity_Model;
using Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class JWTManagerRepository : IJWTManagerRepository
    {
        private readonly IConfiguration iconfiguration;
        private readonly UserManager<User> _userManager;
        private readonly IGenericRepository<User> _userGenericRepository;
        public JWTManagerRepository(IConfiguration iconfiguration, UserManager<User> userManager, IGenericRepository<User> userGenericRepository)
        {
            this.iconfiguration = iconfiguration;
            this._userManager = userManager;
            _userGenericRepository = userGenericRepository;
        }

        public async Task<ResponseRegistration> Register(UserRegistrationModel userModel)
        {
            if (userModel == null)
            {
                return new ResponseRegistration
                {
                    IsSuccess = false


                };
            }

            var existUser = await _userManager.FindByEmailAsync(userModel.Email);
            if (existUser == null)
            {
                return new ResponseRegistration
                {
                    IsEmail = false
                };
            }

            var hasher = new PasswordHasher<IdentityUser>();

            existUser.PasswordHash = hasher.HashPassword(null, userModel.Password);

            await _userGenericRepository.SaveAsync();



            return new ResponseRegistration
            {
                IsSuccess = true,
                IsEmail = true

            };
        }

        public async Task<ResponseLogin> Login(UserLoginDto usermodel)
        {
            var user = await _userManager.FindByEmailAsync(usermodel.Email);
            if (user == null)
            {
                return new ResponseLogin
                {
                    IsSuccess = false
                };
            }
            var userCorrect = await _userManager.CheckPasswordAsync(user, usermodel.Password);
            if (userCorrect == false)
            {
                return new ResponseLogin { IsSuccess = false };
            }

            var userRole = await _userManager.GetRolesAsync(user);

            var result = GenerateJwtToken(usermodel.Email, userRole);

            return new ResponseLogin
            {
                Token = result,
                IsSuccess = true,
            };

        }
        public string GenerateJwtToken(string email, IList<string> roles)
        {
            var issuer = iconfiguration["Jwt:Issuer"];
            var audience = iconfiguration["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes(iconfiguration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim("Id", Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Email, email),
            new Claim(ClaimTypes.Role, string.Join(",", roles)), // Join roles if multiple
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        }),
                Expires = DateTime.UtcNow.AddHours(4),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public async Task<bool> RegistrationNewEmployee(User model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                return false;
            }
            await _userGenericRepository.InsertAsync(model);

            await _userManager.AddToRoleAsync(model, "Employee");
            return true;

        }
        public async Task<User> GetUserAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user;
        }

    }
}
