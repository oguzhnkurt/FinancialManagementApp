using FinancialManagement.Infrastructure.Models.UserModels;
using FinancialManagement.Services.ServiceInterfaces.UserServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagement.Api.Controllers
{
    public class UserController : Controller
    {   
        private readonly IUserManagementService _userManagementService;

        public UserController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }

        public IActionResult AddUser(AddUserRequestDto addUserRequestDto)
        {
            _userManagementService.AddUser(addUserRequestDto);


            return Ok();
        }
    }
}
