using System.Threading.Tasks;
using Upwork.Configuration.Dto;

namespace Upwork.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
