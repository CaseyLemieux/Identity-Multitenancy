using Finbuckle.MultiTenant;

namespace API;

public class CustomStore<TCustomStoreDbContext, TTenant> : IMultiTenantStore<TTenant>
where TCustomStoreDbContext : TenantStoreDbContext
where TTenant : class, ITenantInfo, new()
{
    public Task<bool> TryAddAsync(TTenant tenantInfo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> TryUpdateAsync(TTenant tenantInfo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> TryRemoveAsync(string identifier)
    {
        throw new NotImplementedException();
    }

    public Task<TTenant?> TryGetByIdentifierAsync(string identifier)
    {
        throw new NotImplementedException();
    }

    public Task<TTenant?> TryGetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TTenant>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}