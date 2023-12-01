using AppMvcTiered522.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AppMvcTiered522.Permissions;

public class AppMvcTiered522PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AppMvcTiered522Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AppMvcTiered522Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AppMvcTiered522Resource>(name);
    }
}
