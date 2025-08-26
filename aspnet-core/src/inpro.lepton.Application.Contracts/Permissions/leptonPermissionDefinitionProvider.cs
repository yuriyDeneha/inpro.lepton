using inpro.lepton.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace inpro.lepton.Permissions;

public class leptonPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(leptonPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(leptonPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<leptonResource>(name);
    }
}
