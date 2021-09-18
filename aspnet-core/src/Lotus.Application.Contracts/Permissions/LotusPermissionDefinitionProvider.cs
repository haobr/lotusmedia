using Lotus.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lotus.Permissions
{
    public class LotusPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LotusPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(LotusPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LotusResource>(name);
        }
    }
}
