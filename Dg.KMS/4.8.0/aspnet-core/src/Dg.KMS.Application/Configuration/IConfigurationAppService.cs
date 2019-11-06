using System.Threading.Tasks;
using Dg.KMS.Configuration.Dto;

namespace Dg.KMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
