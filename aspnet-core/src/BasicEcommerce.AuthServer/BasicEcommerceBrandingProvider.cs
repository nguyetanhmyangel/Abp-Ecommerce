using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BasicEcommerce;

[Dependency(ReplaceServices = true)]
public class BasicEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BasicEcommerce";
}
