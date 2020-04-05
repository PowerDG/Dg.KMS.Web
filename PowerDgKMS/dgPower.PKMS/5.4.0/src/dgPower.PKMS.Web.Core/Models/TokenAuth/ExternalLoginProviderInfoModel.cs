using Abp.AutoMapper;
using dgPower.PKMS.Authentication.External;

namespace dgPower.PKMS.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
