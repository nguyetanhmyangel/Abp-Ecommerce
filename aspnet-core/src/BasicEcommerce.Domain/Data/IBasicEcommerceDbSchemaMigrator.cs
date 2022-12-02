using System.Threading.Tasks;

namespace BasicEcommerce.Data;

public interface IBasicEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
