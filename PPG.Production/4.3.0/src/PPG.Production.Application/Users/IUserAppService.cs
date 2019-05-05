using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PPG.Production.Roles.Dto;
using PPG.Production.Users.Dto;

namespace PPG.Production.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}