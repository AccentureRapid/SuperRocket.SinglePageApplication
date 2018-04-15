using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SuperRocket.SinglePageApplication.MultiTenancy;

namespace SuperRocket.SinglePageApplication.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}