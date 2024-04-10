using TractorTracker.Application.Services;
using TractorTracker.Application.Services.Interfaces;
using AutoMapper;
using AppAutoMapper = TractorTracker.Application.Profiles;
using WebAutoMapper = TractorTracker.Web.Profiles;
using TractorTracker.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEquipmentService, EquipmentService>();
builder.Services.AddScoped<IWorkerService, WorkerService>();
builder.Services.AddDbContext<CoreDbContext>();
builder.Services.AddAutoMapper(typeof(AppAutoMapper.AutoMapperConfigProfile));
builder.Services.AddAutoMapper(typeof(WebAutoMapper.AutoMapperConfigProfile));

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

/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");*/

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}");

app.MapControllerRoute(
    name: "Home",
    pattern: "{controller=Home}/{action=Index}");

app.MapControllerRoute(
    name: "User",
    pattern: "{controller=User}/{action=Index}");

app.MapControllerRoute(
    name: "Equipment",
    pattern: "{controller=Equipment}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Note",
    pattern: "{controller=Note}/{action=Index}/{id?}");

app.Run();
