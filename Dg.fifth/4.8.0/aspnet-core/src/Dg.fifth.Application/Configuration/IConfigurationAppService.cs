using System.Threading.Tasks;
using Dg.fifth.Configuration.Dto;

namespace Dg.fifth.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
