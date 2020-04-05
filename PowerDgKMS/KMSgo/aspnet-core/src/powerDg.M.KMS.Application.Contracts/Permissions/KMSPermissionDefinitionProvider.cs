using powerDg.M.KMS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace powerDg.M.KMS.Permissions
{
    public class KMSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(KMSPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(KMSPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<KMSResource>(name);
        }
    }
}
