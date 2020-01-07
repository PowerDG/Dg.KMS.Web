using System.Threading.Tasks;
using Abp.Dependency;

namespace DgInitEFCore.Configuration
{
    public interface ISettingClientVisibilityProvider
    {
        Task<bool> CheckVisible(IScopedIocResolver scope);
    }
}