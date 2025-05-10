using ItlaTvPlus.Application.InterfaceRepositories.Common;
using ItlaTvPlus.Application.InterfaceRepositories.Interfaces;
using ItlaTvPlus.Application.Services;
using ItlaTvPlus.Persitence.Common;
using ItlaTvPlus.Persitence.Context;
using ItlaTvPlus.Persitence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ItlaTvPlusContext>(opt => opt.UseSqlServer(connectionString));

#region Dependency inyection Repository
builder.Services.AddScoped<ISerieRepository, SerieRepository>();
builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IProducerRepsitory, ProducerRepository>();
#endregion

#region Depndency inyection Service
builder.Services.AddScoped<SerieService>();
builder.Services.AddScoped<GenderService>();
builder.Services.AddScoped<ProducerService>();
#endregion

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
