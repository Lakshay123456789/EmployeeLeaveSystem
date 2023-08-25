using BusinessLogicLayer.AccountService.Interface;
using DataAccessLayer.Repository.Interface;
using Models.Dto_Model;
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

        public AccountService(IJWTManagerRepository jWTManagerRepository)
        {

            _jWTManagerRepository = jWTManagerRepository;

        }
        public async Task<ResponseLogin> LoginMethod(UserLoginDto model)
        {
            return await _jWTManagerRepository.Login(model);
        }


    }
}
