using BusinessLogicLayer.AccountService.Interface;
using DataAccessLayer.Repository.Interface;
using Models.Dto_Model;
using Models.Entity_Model;
using Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly IJWTManagerRepository _jWTManagerRepository;
        private readonly IGenericRepository<User> _userRepository;

        public AccountService(IJWTManagerRepository jWTManagerRepository, IGenericRepository<User> userRepository)
        {

            _jWTManagerRepository = jWTManagerRepository;
            _userRepository = userRepository;
        }
        public async Task<ResponseLogin> LoginMethod(UserLoginDto model)
        {
            return await _jWTManagerRepository.Login(model);
        }

        public async Task<bool> RegistrationEmployee (User model)
        {
             return await _jWTManagerRepository.RegistrationNewEmployee(model);
        }

        public async Task<ResponseRegistration> SetPasswordEmployee(UserRegistrationModel model)
        {
            return await _jWTManagerRepository.Register(model);
        }

        public async Task DeleteUser(String email)
        {
            var user= await _jWTManagerRepository.GetUserAsync(email);
            if (user != null)
            {
                await _userRepository.DeleteAsync(user.Id);
            }
        }

    }
}
