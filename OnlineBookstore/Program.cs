using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OnlineBookstore.Domain.Data;
using OnlineBookstore.Domain;
using OnlineBookstore.Infrastructure.Contracts;
using OnlineBookstore.Infrastructure.Repositories;
using OnlineBookstore.Infrastructure.Services; // Ensure this matches your service namespace
using OnlineBookstore.Components;

var builder = WebApplication.CreateBuilder(args);

// 1. Database Connection
var connectionString = builder.Configuration.GetConnectionString("OnlineBookstoreContext")
    ?? throw new InvalidOperationException("Connection string 'OnlineBookstoreContext' not found.");

builder.Services.AddDbContext<OnlineBookstoreContext>(options =>
    options.UseSqlServer(connectionString));

// 2. Identity Configuration
builder.Services.AddIdentityCore<OnlineBookstoreUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<OnlineBookstoreContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// Register Authentication and Cookies
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
.AddIdentityCookies();

builder.Services.AddSingleton(TimeProvider.System);

// --- Custom Service Registrations ---
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
// This line fixes the 'InvalidOperationException'
builder.Services.AddScoped<CartService>();

builder.Services.AddRazorPages();
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Middlewares for security
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapRazorPages();

// Custom Logout Endpoint
app.MapPost("Account/Logout", async (SignInManager<OnlineBookstoreUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/");
});

app.Run();