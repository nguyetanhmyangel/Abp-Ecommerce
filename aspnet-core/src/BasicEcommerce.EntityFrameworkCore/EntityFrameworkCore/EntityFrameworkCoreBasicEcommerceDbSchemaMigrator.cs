using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BasicEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace BasicEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreBasicEcommerceDbSchemaMigrator
    : IBasicEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBasicEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BasicEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BasicEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
