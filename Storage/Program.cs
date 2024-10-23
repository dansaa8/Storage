using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Storage.Data;
var builder = WebApplication.CreateBuilder(args);

// Våran StorageContext registreras som en service. Läggs till i våran dependency injector container
// så att vi har åtkomst till den i resten av applikationen.
builder.Services.AddDbContext<StorageContext>(options =>
    // Här bestäms att SQL-server ska användas som databas.
    // Som argument skickas connection strängen som vi hämtar från våran appsettings.json.
    // Slutligen skickas konfigurationen som ett argument till konstruktorn i StorageContext.
    options.UseSqlServer(builder.Configuration.GetConnectionString("StorageContext") ?? throw new InvalidOperationException("Connection string 'StorageContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
