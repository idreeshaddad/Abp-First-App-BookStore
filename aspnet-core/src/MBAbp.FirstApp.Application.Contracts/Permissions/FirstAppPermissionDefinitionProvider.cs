using MBAbp.FirstApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MBAbp.FirstApp.Permissions;

public class FirstAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FirstAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FirstAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FirstAppResource>(name);
    }
}
