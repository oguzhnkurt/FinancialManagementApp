using AutoMapper;
using FinancialManagement.Infrastructure.Models.UserModels;
using FinancialManagement.Services.ServiceInterfaces.UserServiceInterfaces;

namespace FinancialManagement.Services.Services.UserServices
{

    public class UserManagementService : IUserManagementService
    {

        private readonly IMapper _mapper;

        public UserManagementService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void AddUser(AddUserRequestDto addUserRequest)
        {
            User user = _mapper.Map<User>(addUserRequest);


        }

    }
}
