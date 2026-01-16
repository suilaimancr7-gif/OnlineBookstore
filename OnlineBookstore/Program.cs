using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OnlineBookstore.Domain.Data;
using OnlineBookstore.Domain;
using OnlineBookstore.Infrastructure.Contracts;
using OnlineBookstore.Infrastructure.Repositories;
using OnlineBookstore.Components;

var builder = WebApplication.CreateBuilder(args);

// 1. Database Connection - Matches your appsettings.json
var connectionString = builder.Configuration.GetConnectionString("OnlineBookstoreContext")
    ?? throw new InvalidOperationException("Connection string 'OnlineBookstoreContext' not found.");

builder.Services.AddDbContext<OnlineBookstoreContext>(options =>
    options.UseSqlServer(connectionString));

// 2. Identity Configuration - Following Week 6/7 Lab Skeleton
builder.Services.AddIdentityCore<OnlineBookstoreUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<OnlineBookstoreContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

// 3. Repository Pattern - The "CarRental" Skeleton requirement
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// 4. Standard Blazor/Razor Services
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
app.UseAntiforgery(); // Required for Blazor forms and Identity

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// 5. Map Identity Routes (Matches Lab 6/7)
// Ensure you have scaffolded your Identity pages for this to work.
app.MapRazorPages();

app.Run();