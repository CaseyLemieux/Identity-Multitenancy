using Finbuckle.MultiTenant;

namespace API;

public class Tenant : TenantInfo
{
    public string? Description { get; set; }
}