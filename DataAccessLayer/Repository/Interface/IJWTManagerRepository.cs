using Models.Dto_Model;
using Models.Entity_Model;
using Models.ResponseModel;

namespace DataAccessLayer.Repository.Interface
{
    public interface IJWTManagerRepository
    {
        Task<ResponseRegistration> Register(UserRegistrationModel userModel);

        Task<ResponseLogin> Login(UserLoginDto usermodel);
        Task<bool> RegistrationNewEmployee(User model);

        Task<User> GetUserAsync(string email);
    }
}