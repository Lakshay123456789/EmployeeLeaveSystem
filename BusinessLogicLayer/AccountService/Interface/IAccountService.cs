using Models.Dto_Model;
using Models.ResponseModel;

namespace BusinessLogicLayer.AccountService.Interface
{
    public interface IAccountService
    {
        Task<ResponseLogin> LoginMethod(UserLoginDto model);
    }
}