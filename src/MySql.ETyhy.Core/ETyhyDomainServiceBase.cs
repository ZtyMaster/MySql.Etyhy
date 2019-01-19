

using Abp.Domain.Services;

namespace MySql.ETyhy
{
	public abstract class ETyhyDomainServiceBase : DomainService
	{
		/* Add your common members for all your domain services. */
		/*在领域服务中添加你的自定义公共方法*/





		protected ETyhyDomainServiceBase()
		{
			LocalizationSourceName = ETyhyConsts.LocalizationSourceName;
		}
	}
}
