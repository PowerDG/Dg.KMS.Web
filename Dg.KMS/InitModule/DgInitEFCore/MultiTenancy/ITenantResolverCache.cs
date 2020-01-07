using JetBrains.Annotations;

namespace DgInitEFCore.MultiTenancy
{
    public interface ITenantResolverCache
    {
        [CanBeNull]
        TenantResolverCacheItem Value { get; set; }
    }
}