using BasicEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BasicEcommerce.Permissions;

public class BasicEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BasicEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BasicEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BasicEcommerceResource>(name);
    }
}
