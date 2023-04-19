using DDDTemplateSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DDDTemplateSolution.Permissions;

public class DDDTemplateSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DDDTemplateSolutionPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DDDTemplateSolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DDDTemplateSolutionResource>(name);
    }
}
