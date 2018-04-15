using Abp.AutoMapper;
using SuperRocket.SinglePageApplication.Sessions.Dto;

namespace SuperRocket.SinglePageApplication.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}