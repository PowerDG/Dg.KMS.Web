using System.Threading.Tasks;
using dgPower.PKMS.Configuration.Dto;

namespace dgPower.PKMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
