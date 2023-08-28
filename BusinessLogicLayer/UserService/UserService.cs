using BusinessLogicLayer.UserService.Interface;
using DataAccessLayer.Repository.Interface;
using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.UserService
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<LeaveRequest> _LeavegenericRepository;

        public UserService(IGenericRepository<LeaveRequest> LeavegenericRepository)
        {

            _LeavegenericRepository = LeavegenericRepository;
        }

        public async Task<List<LeaveRequest>> GetParticularLeave(Guid Id)
        {
            return await _LeavegenericRepository.GetAllUsersLeave(Id);


        }


    }
}
