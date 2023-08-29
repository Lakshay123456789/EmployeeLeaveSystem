using Models.Dto_Model;
using Models.Entity_Model;

namespace BusinessLogicLayer.UserService.Interface
{
    public interface IUserService
    {
        Task<List<LeaveRequest>> GetParticularLeave(Guid Id);
        Task ApplyForLeave(LeaveRequestDto leaveRequestDto);
    }
}