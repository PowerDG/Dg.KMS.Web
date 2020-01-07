namespace DgInitEFCore.MultiTenancy
{
    public interface ITenantResolver
    {
        int? ResolveTenantId();
    }
}