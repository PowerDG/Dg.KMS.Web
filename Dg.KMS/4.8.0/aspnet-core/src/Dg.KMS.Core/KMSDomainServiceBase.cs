

using Abp.Domain.Services;

namespace Dg.KMS
{
	public abstract class KMSDomainServiceBase : DomainService
	{
		/* Add your common members for all your domain services. */
		/*在领域服务中添加你的自定义公共方法*/





		protected KMSDomainServiceBase()
		{
			LocalizationSourceName = KMSConsts.LocalizationSourceName;
		}
	}
}
