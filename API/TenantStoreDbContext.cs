using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API;

public class TenantStoreDbContext : MultiTenantIdentityDbContext<User>
{
    public TenantStoreDbContext(ITenantInfo tenantInfo) : base(tenantInfo)
    {
    }

    public TenantStoreDbContext(ITenantInfo tenantInfo, DbContextOptions options) : base(tenantInfo, options)
    {
    }
}