using Models.Dto_Model;
using Models.Entity_Model;
using Models.ResponseModel;

namespace BusinessLogicLayer.AccountService.Interface
{
    public interface IAccountService
    {
        Task<ResponseLogin> LoginMethod(UserLoginDto model);
        Task<bool> RegistrationEmployee(User model);
        Task<ResponseRegistration> SetPasswordEmployee(UserRegistrationModel model);
        Task DeleteUser(String email);
    }
}