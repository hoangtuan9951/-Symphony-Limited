using Symphony.Ltd.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Symphony.Ltd.Permissions;

public class LtdPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LtdPermissions.GroupName);

        myGroup.AddPermission(LtdPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(LtdPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(LtdPermissions.MyPermission1, L("Permission:MyPermission1"));

        var coursePermission = myGroup.AddPermission(LtdPermissions.Courses.Default, L("Permission:Courses"));
        coursePermission.AddChild(LtdPermissions.Courses.Create, L("Permission:Create"));
        coursePermission.AddChild(LtdPermissions.Courses.Edit, L("Permission:Edit"));
        coursePermission.AddChild(LtdPermissions.Courses.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LtdResource>(name);
    }
}