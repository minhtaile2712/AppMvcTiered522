using Volo.Abp.Reflection;

namespace MyShareModule.Permissions;

public class MyShareModulePermissions
{
    public const string GroupName = "MyShareModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(MyShareModulePermissions));
    }
}
