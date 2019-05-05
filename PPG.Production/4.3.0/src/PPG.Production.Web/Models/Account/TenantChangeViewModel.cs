using Abp.AutoMapper;
using PPG.Production.Sessions.Dto;

namespace PPG.Production.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}