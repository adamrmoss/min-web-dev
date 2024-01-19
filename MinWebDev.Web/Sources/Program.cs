var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the app using attribute routing
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
