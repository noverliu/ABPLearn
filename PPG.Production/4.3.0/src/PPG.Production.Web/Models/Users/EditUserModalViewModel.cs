using System.Collections.Generic;
using System.Linq;
using PPG.Production.Roles.Dto;
using PPG.Production.Users.Dto;

namespace PPG.Production.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.Name);
        }
    }
}