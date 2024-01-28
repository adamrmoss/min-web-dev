using Microsoft.EntityFrameworkCore;
using MinWebDev.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                       ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."); ;

builder.Services.AddDbContext<MinWebDevDbContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICandidateDao, CandidateDao>();
builder.Services.AddScoped<ISchoolAttendanceDao, SchoolAttendanceDao>();
builder.Services.AddScoped<ISkillExperienceDao, SkillExperienceDao>();
builder.Services.AddScoped<IEmploymentTermDao, EmploymentTermDao>();

var app = builder.Build();

// Configure the app using attribute routing
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
