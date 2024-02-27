using System;
using System.Globalization;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OtpTaskFinal.Services.SMTP;
using OtpTaskFinal.Models;
using OtpTaskFinal.EFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(o => o.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
builder.Services.AddDbContext<AppDbContext>(option=> option.UseSqlite("Data Source=D:/.net/OtpTaskFinal/dbMain.db"));
builder.Services.AddIdentity<AppUser, IdentityRole>(op =>
{
    /*Identity Options*/
    //Password option

    //Lockout options
    op.Lockout.MaxFailedAccessAttempts = 3;
    op.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
    
    //Email conformation options
    
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
builder.Services.AddTransient<IEmailSender, EmailSender>();

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
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");

app.Run();