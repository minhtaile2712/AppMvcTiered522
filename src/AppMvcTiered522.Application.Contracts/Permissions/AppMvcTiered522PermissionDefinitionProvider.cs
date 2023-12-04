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

        var booksPermission = myGroup.AddPermission(AppMvcTiered522Permissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AppMvcTiered522Permissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AppMvcTiered522Permissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AppMvcTiered522Permissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = myGroup.AddPermission(AppMvcTiered522Permissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(AppMvcTiered522Permissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(AppMvcTiered522Permissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(AppMvcTiered522Permissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AppMvcTiered522Resource>(name);
    }
}
