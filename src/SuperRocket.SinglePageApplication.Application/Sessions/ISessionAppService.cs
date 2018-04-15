using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.SinglePageApplication.Sessions.Dto;

namespace SuperRocket.SinglePageApplication.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
