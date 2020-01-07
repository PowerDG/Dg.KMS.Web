namespace DgInitEFCore.MultiTenancy
{
    public interface ITenantResolveContributor
    {
        int? ResolveTenantId();
    }
}