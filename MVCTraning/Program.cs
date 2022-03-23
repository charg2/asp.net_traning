using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCTraning.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MvcMovieContext>( options =>
     options.UseMySql( @"Server=127.0.0.1; Database=moives; User=root; Pwd=zx0925^^",
                         MySqlServerVersion.Parse( "8.0.22-mysql" ) ) );
     //builder.Configuration.GetConnectionString( "MvcMovieContext" ) ); ; ;/ ;//);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( !app.Environment.IsDevelopment() )
{
    app.UseExceptionHandler( "/Home/Error" );
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}" );

app.Run();
