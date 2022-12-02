using System;
using System.Collections.Generic;
using System.Text;
using BasicEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace BasicEcommerce;

/* Inherit your application services from this class.
 */
public abstract class BasicEcommerceAppService : ApplicationService
{
    protected BasicEcommerceAppService()
    {
        LocalizationResource = typeof(BasicEcommerceResource);
    }
}
