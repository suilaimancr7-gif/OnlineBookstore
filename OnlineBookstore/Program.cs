using Microsoft.EntityFrameworkCore;
using OnlineBookstore.Domain.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Register DbContext
builder.Services.AddDbContext<OnlineBookstoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineBookstoreContext")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapRazorComponents<App>();

app.Run();
