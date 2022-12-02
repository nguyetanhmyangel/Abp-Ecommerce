using System;
using System.Collections.Generic;
using System.Text;
using BasicEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace BasicEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class BasicEcommerceAdminAppService : ApplicationService
{
    protected BasicEcommerceAdminAppService()
    {
        LocalizationResource = typeof(BasicEcommerceResource);
    }
}
