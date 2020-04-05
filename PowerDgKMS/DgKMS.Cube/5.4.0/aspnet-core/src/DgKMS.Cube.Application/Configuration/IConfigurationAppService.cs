using System.Threading.Tasks;
using DgKMS.Cube.Configuration.Dto;

namespace DgKMS.Cube.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
