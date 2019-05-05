using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PPG.Production.Roles.Dto;

namespace PPG.Production.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
