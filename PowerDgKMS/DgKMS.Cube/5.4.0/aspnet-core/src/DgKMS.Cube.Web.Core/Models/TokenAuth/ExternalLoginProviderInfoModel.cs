using Abp.AutoMapper;
using DgKMS.Cube.Authentication.External;

namespace DgKMS.Cube.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
