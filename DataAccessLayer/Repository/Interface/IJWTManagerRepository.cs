using Models.Dto_Model;
using Models.ResponseModel;

namespace DataAccessLayer.Repository.Interface
{
    public interface IJWTManagerRepository
    {
        Task<ResponseRegistration> Register(UserRegistrationModel userModel);

        Task<ResponseLogin> Login(UserLoginDto usermodel);
    }
}