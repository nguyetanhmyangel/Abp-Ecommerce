using BasicEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BasicEcommerce;

[DependsOn(
    typeof(BasicEcommerceEntityFrameworkCoreTestModule)
    )]
public class BasicEcommerceDomainTestModule : AbpModule
{

}
