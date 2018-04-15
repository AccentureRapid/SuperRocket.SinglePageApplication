using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.SinglePageApplication.Configuration.Dto;

namespace SuperRocket.SinglePageApplication.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}