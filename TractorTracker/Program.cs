var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
