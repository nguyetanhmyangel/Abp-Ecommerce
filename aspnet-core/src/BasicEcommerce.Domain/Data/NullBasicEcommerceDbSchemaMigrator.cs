using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BasicEcommerce.Data;

/* This is used if database provider does't define
 * IBasicEcommerceDbSchemaMigrator implementation.
 */
public class NullBasicEcommerceDbSchemaMigrator : IBasicEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
