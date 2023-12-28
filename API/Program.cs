using API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TenantStoreDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//No Idea what this does
builder.Services.AddHttpClient();

builder.Services.AddDistributedMemoryCache();
//Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowLocalFrontendCORS",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000", "http://localhost:5103")
                .AllowCredentials();
        });
});

//Add Multi-tenant
builder.Services.AddMultiTenant<Tenant>()
    .WithStore<CustomStore<TenantStoreDbContext, Tenant>>(ServiceLifetime.Scoped)
    .WithRouteStrategy("tenant");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors("AllowLocalFrontendCORS");
app.UseMultiTenant();

app.UseAuthorization();

app.MapControllers();

app.Run();
