using Volo.Abp.Modularity;

namespace BasicEcommerce;

[DependsOn(
    typeof(BasicEcommerceApplicationModule),
    typeof(BasicEcommerceDomainTestModule)
    )]
public class BasicEcommerceApplicationTestModule : AbpModule
{

}
