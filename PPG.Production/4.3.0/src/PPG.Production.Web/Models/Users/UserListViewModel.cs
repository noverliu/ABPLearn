using System.Collections.Generic;
using PPG.Production.Roles.Dto;
using PPG.Production.Users.Dto;

namespace PPG.Production.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}