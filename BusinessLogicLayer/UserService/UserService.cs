using AutoMapper;
using BusinessLogicLayer.UserService.Interface;
using DataAccessLayer.Repository.Interface;
using Models.Dto_Model;
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
        private readonly IMapper _mapper;
        private readonly IGenericRepository<LeaveRequest> _LeavegenericRepository;

        public UserService(IGenericRepository<LeaveRequest> LeavegenericRepository,IMapper mapper)
        {
            _mapper = mapper;
            _LeavegenericRepository = LeavegenericRepository;
        }

        public async Task<List<LeaveRequest>> GetParticularLeave(Guid Id)
        {
            return await _LeavegenericRepository.GetAllUsersLeave(Id);


        }

        public async Task ApplyForLeave(LeaveRequestDto leaveRequestDto)
        {
            var leaveRequest= _mapper.Map<LeaveRequest>(leaveRequestDto);

            await _LeavegenericRepository.InsertAsync(leaveRequest);

        }
        
        

    }
}
