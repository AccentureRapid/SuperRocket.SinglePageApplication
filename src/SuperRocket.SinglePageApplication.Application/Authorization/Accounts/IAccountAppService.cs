using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.SinglePageApplication.Authorization.Accounts.Dto;

namespace SuperRocket.SinglePageApplication.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
