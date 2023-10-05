using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RisoOdonto.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RisoOdontoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RisoOdontoContext") ?? throw new InvalidOperationException("Connection string 'RisoOdontoContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Agendamentoes}/{action=Agendamento}/{id?}");

app.Run();
