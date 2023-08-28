using Models.Entity_Model;

namespace BusinessLogicLayer.UserService.Interface
{
    public interface IUserService
    {
        Task<List<LeaveRequest>> GetParticularLeave(Guid Id);
    }
}