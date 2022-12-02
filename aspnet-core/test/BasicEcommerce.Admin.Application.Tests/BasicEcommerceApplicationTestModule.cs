using Volo.Abp.Modularity;

namespace BasicEcommerce.Admin;

[DependsOn(
    typeof(BasicEcommerceAdminApplicationModule),
    typeof(BasicEcommerceDomainTestModule)
    )]
public class BasicEcommerceApplicationTestModule : AbpModule
{

}
