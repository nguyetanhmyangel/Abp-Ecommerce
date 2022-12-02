using Volo.Abp.Settings;

namespace BasicEcommerce.Settings;

public class BasicEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BasicEcommerceSettings.MySetting1));
    }
}
