using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OnlineBookstore.Domain.Data;
using OnlineBookstore.Domain;
using OnlineBookstore.Infrastructure.Contracts;
using OnlineBookstore.Infrastructure.Repositories;
using OnlineBookstore.Components;

var builder = WebApplication.CreateBuilder(args);

// 1. Database Connection - Configured for design-time migrations
var connectionString = builder.Configuration.GetConnectionString("OnlineBookstoreContext")
    ?? throw new InvalidOperationException("Connection string 'OnlineBookstoreContext' not found.");

builder.Services.AddDbContext<OnlineBookstoreContext>(options =>
    options.UseSqlServer(connectionString));

// 2. Identity Configuration - Standard Identity Setup
builder.Services.AddIdentityCore<OnlineBookstoreUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<OnlineBookstoreContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// 3. Fix for 'System.TimeProvider' Error
// This service is required by modern Identity SecurityStampValidators
builder.Services.AddSingleton(TimeProvider.System);

// 4. Repository Pattern - The "CarRental" Skeleton requirement
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// 5. Standard Blazor/Razor Services
builder.Services.AddRazorPages();
builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
app.UseAntiforgery(); // Essential for Blazor and Identity security

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// 6. Map Identity and Razor Pages
app.MapRazorPages();

app.MapPost("Account/Logout", async (
    SignInManager<OnlineBookstoreUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.Redirect("/");
});


app.Run();