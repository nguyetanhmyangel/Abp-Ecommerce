using BasicEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BasicEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BasicEcommerceController : AbpControllerBase
{
    protected BasicEcommerceController()
    {
        LocalizationResource = typeof(BasicEcommerceResource);
    }
}
