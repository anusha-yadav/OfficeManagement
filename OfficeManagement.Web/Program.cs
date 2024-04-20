using Microsoft.EntityFrameworkCore;
using OfficeManagement.Data.Entities;
using OfficeManagement.Repository.Contracts;
using OfficeManagement.Repository.Implementation;
using OfficeManagement.Services.Implementation;
using OfficeManagement.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

//Dependancy Injection
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<IUnitofWork,UnitOfWork>();


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OfficeDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DbContext")));

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
    pattern: "{controller=Office}/{action=Index}/{id?}");

app.Run();
