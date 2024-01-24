using Microsoft.AspNetCore.Mvc;

using MinWebDev;
using MinWebDev.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMinWebDevDao, MinWebDevDao>();

var app = builder.Build();

// Configure the app using attribute routing
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
