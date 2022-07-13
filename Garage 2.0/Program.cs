using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Garage_2._0.Data;
using Garage_2._0.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Garage_2_0Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Garage_2_0Context") ?? throw new InvalidOperationException("Connection string 'Garage_2_0Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Lade till en service för VehicleTypesSelectListService som skapar en selectlista (dropdownmeny) för alla fordonstyper
builder.Services.AddScoped<IVehicleTypesSelectListService, VehicleTypesSelectListService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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
    pattern: "{controller=ParkedVehicles}/{action=Index}/{id?}");

app.Run();
