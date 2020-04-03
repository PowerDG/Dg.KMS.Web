using Abp.AutoMapper;
using dgPower.KMS.Authentication.External;

namespace dgPower.KMS.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
