using System.Threading.Tasks;
using dgPower.KMS.Configuration.Dto;

namespace dgPower.KMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
