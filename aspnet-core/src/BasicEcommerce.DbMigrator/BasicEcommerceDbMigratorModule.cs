using BasicEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BasicEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BasicEcommerceEntityFrameworkCoreModule),
    typeof(BasicEcommerceApplicationContractsModule)
    )]
public class BasicEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
