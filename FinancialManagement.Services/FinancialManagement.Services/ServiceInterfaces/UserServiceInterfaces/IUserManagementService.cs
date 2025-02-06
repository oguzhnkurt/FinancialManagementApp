using FinancialManagement.Infrastructure.Models.UserModels;

namespace FinancialManagement.Services.ServiceInterfaces.UserServiceInterfaces
{
    public interface IUserManagementService
    {
        void AddUser(AddUserRequestDto addUserRequest);
    }
}
