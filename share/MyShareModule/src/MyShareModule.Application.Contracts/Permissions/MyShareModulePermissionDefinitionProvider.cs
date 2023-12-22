using MyShareModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyShareModule.Permissions;

public class MyShareModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyShareModulePermissions.GroupName, L("Permission:MyShareModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyShareModuleResource>(name);
    }
}
